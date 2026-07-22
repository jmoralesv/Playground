# Playground
This is a playground project, to play with C# and .NET 🎉

# Prerequisites
* Visual Studio 2026
* .NET 10.0 SDK
* .NET 10.0
* Git
* Enjoying learning C# 🎉

# Central Package Management
This solution uses central package management via MSBuild files located in the `src/` folder next to the solution file:

* `Directory.Build.props` — shared MSBuild properties for all projects in the solution, such as the target framework, implicit usings, analyzer levels, and warning-as-error behavior.
* `Directory.Packages.props` — enables centralized NuGet package version management. Individual project files reference packages without specifying a version; versions are defined here once for the whole solution.

Project-specific settings (for example, `OutputType`, `UseWindowsForms`, content items, and project references) remain in each `.csproj` file and take precedence over the shared properties when needed.