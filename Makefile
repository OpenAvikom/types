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

# Parameters that are required for packaging
USER ?= unset
EMAIL ?= unset@localhost


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
	-exec sed \
	-i'' \
	-e 's/\(from \|import \|\[\|-> \|: \|.__module__. : .\)avikom\./\1avikom_types\.avikom\./g' {} \;
	# add empty __init__ files for import
	find $(PROTO_OUT)/python/avikom_types/* \
	-type d -exec touch {}/__init__.py \;

python_package:
	@if [ ! "$(VERSION)" ]; then \
        echo "VERSION must be specified!"; \
        exit 1; \
    fi
	echo "__version__ = '${VERSION}'" > $(PROTO_OUT)/python/avikom_types/version.py
	python -m build \
	--sdist \
	--wheel \
	--outdir $(PROTO_OUT)/python/dist \
	$(PROTO_OUT)/python

python: python_generate python_package

csharp_generate:
	mkdir -p $(PROTO_OUT)
	rm -rf $(PROTO_OUT)/csharp
	mkdir $(PROTO_OUT)/csharp
	cp -r templates/csharp/* $(PROTO_OUT)/csharp/
	dotnet build csharp
	python generators/generate_constants.py\
		-o $(PROTO_OUT)/csharp\
		-r $(PROTO_IN)/../constants\
		-t cs\
		$(PROTO_IN)/../constants/**/**/*.json

unity_generate:
	cp -r templates/unity/* $(PROTO_OUT)/unity/
	find  $(PROTO_OUT)/unity/Types -iname "*.cs" -delete
	find  $(PROTO_OUT)/unity/UnityTypes -iname "*.cs" -delete

	protoc \
		$(INCLUDES) \
		--plugin=protoc-gen-unity_type=./generators/protoc-gen-unity_type \
		--unity_type_out=$(PROTO_OUT)/unity/UnityTypes \
		$(PROTO_IN)/**/**/*.proto

	protoc \
		$(INCLUDES) \
		--plugin=protoc-gen-unity_set=./generators/protoc-gen-unity_set \
		--unity_set_out=$(PROTO_OUT)/unity/UnityTypes \
		$(PROTO_IN)/**/**/*.proto

	protoc \
		$(INCLUDES) \
		--plugin=protoc-gen-unity_set=./generators/protoc-gen-unity_enum \
		--unity_set_out=$(PROTO_OUT)/unity/UnityTypes \
		$(PROTO_IN)/**/**/*.proto

	cp -r $(PROTO_OUT)/csharp/Avikom $(PROTO_OUT)/unity/Types/

unity_publish:
	@if [ ! "$(VERSION)" ]; then \
        echo "VERSION must be specified!"; \
        exit 1; \
    fi
	sed -i'' -e 's/@VERSION@/${VERSION}/g' ${PROTO_OUT}/unity/package.json
	git -C ${PROTO_OUT}/unity config --local user.email "${EMAIL}"
	git -C ${PROTO_OUT}/unity config --local user.name "${USER}"
	git -C ${PROTO_OUT}/unity commit --allow-empty -am "release ${VERSION}"
	git -C ${PROTO_OUT}/unity tag upm-${VERSION}
	git -C ${PROTO_OUT}/unity push --atomic origin upm upm-${VERSION}

unity: python_generate csharp_generate unity_generate unity_publish
