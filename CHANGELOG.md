# Code Editor Package for Visual Studio

## [2.0.25] - 2025-09-16

Internal:

- Fixes for release validation and release process

## [2.0.24] - 2025-09-04

Integration:

- Remove support for `Visual Studio for Mac`. Please use `VS Code` going forward.
- Performance optimizations.

Project generation:

- Allow customization of `langversion` when using a `rsp` file.
- Move to `slnx` solution generation when using `SDK-Style` projects.
- Both `VS Code` and `Visual Studio 2026` are now using `SDK-Style` projects by default.

## [2.0.23] - 2025-02-03

Integration:

- Monitor `additionalfile` extension by default.
- Try opening a VSC-Based Editor workspace if there's one (`.code-workspace` file in the Unity project).

Project generation:

- Identify `asset`, `meta`, `prefab` and `unity` files as `yaml` (VSC-Based Editor).
- Add `sln`/`csproj` file nesting (VSC-Based Editor).
- Improve SDK style project generation.
