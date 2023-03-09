PROTO_IN = $(CURDIR)/protos
PROTO_COMMON = $(CURDIR)/contrib/api-common-protos
PROTO_OUT = $(CURDIR)/generated
NODE_EXE_PATH = $(CURDIR)/node_modules/.bin
PROTOC_GEN_TS_PATH = $(NODE_EXE_PATH)/protoc-gen-ts
PROTOC_GEN_JS_PATH = $(NODE_EXE_PATH)/grpc_tools_node_protoc
GOPATH = $(shell go env GOPATH)

INCLUDES = -I$(PROTO_IN) \
		   -I/usr/local/include \
		   -I/usr/include \
		   -I$(PROTO_COMMON)

    
java_generate:
	mkdir -p $(PROTO_OUT)
	rm -rf $(PROTO_OUT)/java
	cp -r templates/java $(PROTO_OUT)/java
	mvn -f $(PROTO_OUT)/java compile

java_package:
	# VERSION must be set!
	sed -i "s/@VERSION@/${VERSION}/g" $(PROTO_OUT)/java/pom.xml
	
java_publish:
	# GITHUB_TOKEN must be set!
	mvn -f $(PROTO_OUT)/java -s mvn_settings.xml deploy

java: java_generate java_package

python_generate:
	mkdir -p $(PROTO_OUT)
	rm -rf $(PROTO_OUT)/python
	cp -r templates/python $(PROTO_OUT)/python
	pip install \
	-r $(PROTO_OUT)/python/requirements.txt \
	-r $(PROTO_OUT)/python/requirements_dev.txt
	python -m grpc_tools.protoc \
		$(INCLUDES) \
		--python_out=$(PROTO_OUT)/python/avikom_types \
		--grpc_python_out=$(PROTO_OUT)/python/avikom_types \
		--mypy_out=$(PROTO_OUT)/python/avikom_types \
		$(PROTO_IN)/**/**/*.proto
	# make paths in pyi files absolute
	find $(PROTO_OUT)/python/avikom_types \
	-type f \( -iname \*.py -o -iname \*.pyi \) \
	-exec sed -i '' \
	-e 's/\(from \|import \|\[\|-> \|: \|.__module__. : .\)avikom\./\1avikom_types\.avikom\./g' {} \;
	# add empty __init__ files for import
	find $(PROTO_OUT)/python/avikom_types/* \
	-type d -exec touch {}/__init__.py \;

python_package:
	# VERSION must be set!
	echo "__version__ = '${VERSION}'" > $(PROTO_OUT)/python/avikom_types/version.py
	python -m build \
	--sdist \
	--wheel \
	--outdir $(PROTO_OUT)/python/dist \
	$(PROTO_OUT)/python

python: python_generate python_package
