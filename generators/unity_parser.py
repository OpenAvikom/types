#!/usr/bin/env python

from protoc_base_plugin.parser import ParserBase, indent
from protoc_base_plugin.generators.text_parser import TextParser
import sys
import pprint

from protoc_base_plugin.utils import Capitalize, camelCase, PascalCase


class UnityParser(ParserBase):

    type_mapper = {
        "TYPE_STRING": "StringVariable",
        "TYPE_MESSAGE": "{class_name}",
        "TYPE_ENUM": "{class_name}",
        "TYPE_BOOL": "BoolVariable",
        "TYPE_UINT64": "UnsignedLongVariable",
        "TYPE_UINT32": "UnsignedIntVariable",
        "TYPE_INT32": "IntVariable",
        "TYPE_FLOAT": "FloatVariable",
        "TYPE_SFIXED32": "IntVariable",
        "TYPE_BYTES": "ByteArrayVariable",
    }

    meta_comment_template = "/** {comment} */"
    definition_comment_template = "/** {comment} */"
    field_comment_template = "// {comment}"

    def process_meta(self, meta, parsed_definitions):
        parsed_definitions = [item for item in parsed_definitions if item]
        if not parsed_definitions:
            return ""
        try:
            csharp_namespace = meta.get("options")["csharp_namespace"]
        except KeyError:
            return ""
        comment = meta.get("comment")
        comment = self.meta_comment_template.format(comment=comment) if comment else ""
        return self.meta_template.format(
            parsed_definitions=indent(
                "\n".join(parsed_definitions), self.indent_char * self.indent_level
            ),
            csharp_namespace=csharp_namespace,
            message_namespace=csharp_namespace.replace("Types", "UnityTypes"),
            service_namespace=csharp_namespace.replace("Types", "UnityServices"),
            parsed_comment=comment,
        )

    def process_field(self, field, definition, meta, template):
        try:  # messages
            # print(field, file=sys.stderr)
            field["name"] = PascalCase(field["name"])
            if "type_name" in field:
                field["full_name"] = PascalCase(field["type_name"])
                class_name = field["full_name"].split(".")
                class_name = class_name[:1] + ["UnityTypes"] + class_name[1:]
                field["class_name"] = ".".join(class_name)
            field["type"] = self.type_mapper[field["type"]].format(**field)
            if field["label"] == "LABEL_REPEATED":
                field["list_type"] = f"{field['type']}Set"
            else:
                field["list_type"] = field["type"]
        except KeyError:  # services and enums
            field["list_type"] = field["type"]
        return super().process_field(field, definition, meta, template)

    @staticmethod
    def get_filename(proto_name: str) -> str:
        return PascalCase(proto_name).replace(".Proto", ".cs")

    # def process_raw(self, result):
    #     # print(result, file=sys.stderr)
    #     result = super().process_raw(result)
    #     print(result, file=sys.stderr)
    #     # print("------------", file=sys.stderr)
    #     return result

    # @staticmethod
    # def process_output(output):
    #     return
