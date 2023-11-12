import json
import argparse
import glob
from pathlib import Path
import dataclasses
from typing import List

from protoc_base_plugin.utils import (
    Capitalize,
    camelCase,
    PascalCase,
    underscore_notation,
)

# python generators/generate_constants.py -r ../constants -t python -o generated/constants/avikom ../constants/**/*.json


@dataclasses.dataclass
class DataValue:
    name: str
    description: str


@dataclasses.dataclass
class DataClass:
    name: str
    description: str
    values: List[DataValue]


class Generator:
    def add_class(self, definition: DataClass):
        pass

    def save(self):
        self.out_file.parent.mkdir(exist_ok=True, parents=True)
        with open(self.out_file, "w") as stream:
            stream.write(self.data)


class PythonGenerator(Generator):
    def __init__(self, root: Path, namespace: Path, base: str) -> None:
        self.data = ""
        self.out_file = Path.joinpath(
            root, namespace, Path(f"constants/{base}.py")
        ).absolute()

    def add_class(self, definition: DataClass):
        if self.data:
            self.data += "\n\n"
        self.data += f"class {PascalCase(definition.name)}:\n"
        if definition.description:
            self.data += f'    """ {definition.description} """\n'
        self.data += "\n"
        for value in definition.values:
            self.data += f'    {value.name.upper()} = "{PascalCase(value.name)}"\n'
            if value.description:
                self.data += f'    """ {value.description} """\n'
            self.data += "\n"


class TypescriptGenerator(Generator):
    def __init__(self, root: Path, namespace: Path, base: str) -> None:
        self.data = ""
        self.out_file = Path.joinpath(
            root, namespace, Path(f"constants/{base}.ts")
        ).absolute()

    def add_class(self, definition: DataClass):
        if definition.description:
            self.data += f"// {definition.description}\n"
        self.data += f"export class {PascalCase(definition.name)} {{"
        for value in definition.values:
            self.data += "\n"
            if value.description:
                self.data += f"  // {value.description}\n"
            self.data += f'  static readonly {PascalCase(value.name)} = "{PascalCase(value.name)}"\n'
        self.data += "}\n"

    def save(self):
        self.out_file.parent.mkdir(exist_ok=True, parents=True)
        with open(self.out_file, "w") as stream:
            stream.write(self.data)


class CSharpGenerator(Generator):
    def __init__(self, root: Path, namespace: Path, base: str) -> None:
        package = [Capitalize(part) for part in namespace.parts]
        package.insert(1, "Constants")
        self.data = f"namespace {'.'.join(package)} {{\n"
        self.out_file = Path.joinpath(
            root,
            Path("/".join([Capitalize(part) for part in namespace.parts])),
            Path(f"{PascalCase(base)}Constants.cs"),
        ).absolute()

    def add_class(self, definition: DataClass):
        if definition.description:
            self.data += f"    // {definition.description}\n"
        self.data += f"    public class {PascalCase(definition.name)}\n    {{"
        for value in definition.values:
            self.data += "\n"
            if value.description:
                self.data += f"        // {value.description}\n"
            self.data += f'        public const string {PascalCase(value.name)} = "{PascalCase(value.name)}";\n'
        self.data += "    }\n"

    def save(self):
        self.out_file.parent.mkdir(exist_ok=True, parents=True)
        self.data += "}\n"
        if self.out_file.exists():
            raise FileExistsError(self.out_file)
        with open(self.out_file, "w") as stream:
            stream.write(self.data)


class RSTGenerator(Generator):
    def __init__(self, root: Path, namespace: Path, base: str) -> None:
        self.namespace = ".".join(namespace.parts) + ".constants"
        file_uri = str(Path.joinpath(namespace, Path(f"{base}.json")))
        self.out_file = Path.joinpath(
            root, namespace, Path(f"constants_{base}.rst")
        ).absolute()
        self.data = (
            f".. _{file_uri}:\n\n{file_uri}\n"
            + "=" * len(file_uri)
            + "\n\n.. contents:: Definitions\n   :local:\n"
        )

    def add_class(self, definition: DataClass):
        class_name = PascalCase(definition.name)
        self.data += f"\n\n.. _{self.namespace}.{PascalCase(definition.name)}:\n\n"
        self.data += f"{class_name}\n"
        self.data += "-" * len(class_name)
        self.data += "\n"
        if definition.description:
            self.data += f"{definition.description}\n"
        self.data += '\n.. csv-table::\n   :header: "Name", "Value", "Description"\n   :widths: auto\n\n'
        for value in definition.values:
            self.data += f'   {value.name.upper()}, "{PascalCase(value.name)}", "{value.description}"\n'


def dir_path(string):
    path = Path(string)
    if path.is_dir():
        return path
    else:
        raise NotADirectoryError(string)


def globable_file_path(string):
    files = glob.glob(string)
    if files:
        return files
    else:
        raise FileNotFoundError(string)


generators = dict(
    py=PythonGenerator, ts=TypescriptGenerator, cs=CSharpGenerator, rst=RSTGenerator
)

parser = argparse.ArgumentParser(
    description="Converts JSON constant definition into code."
)
parser.add_argument(
    "-t", "--to", choices=list(generators.keys()), help="target ", required=True
)
parser.add_argument("-o", "--out", help="output path", type=dir_path, required=True)
parser.add_argument(
    "-r", "--root", help="root of the definition tree", type=dir_path, required=True
)
parser.add_argument(
    "input", type=globable_file_path, help="globable path to input files"
)
args = parser.parse_args()

definitions = {}

for file in args.input:
    with open(file, "r") as stream:
        data = json.load(stream)
        definitions[file] = []
        for name, def_class in data.items():
            data_class = DataClass(
                name=name, description=def_class.get("description", ""), values=[]
            )
            for def_value in def_class["values"]:
                data_class.values.append(
                    DataValue(
                        name=def_value["name"],
                        description=def_value.get("description", ""),
                    )
                )
            definitions[file].append(data_class)

for file, classes in definitions.items():
    tree = Path(file).relative_to(args.root)
    p = generators[args.to](
        args.out,
        tree.parent,
        tree.stem,
    )
    for cls in classes:
        p.add_class(cls)
    p.save()
