# Building from Source

This project targets **.NET Framework 3.5** and was created with **Visual Studio 2017**. Building on Windows with Visual Studio is recommended.

## Prerequisites

1. **Visual Studio 2017 or later** with the _.NET desktop development_ workload installed.
2. **Decal 3.0 SDK** – provides `Decal.Adapter.dll` and `Decal.FileService.dll`.
   Install Decal to the default location (`C:\Program Files (x86)\Decal 3.0\`).
3. **Virindi Bundle** – provides `VirindiViewService.dll` (`C:\Games\VirindiPlugins\VirindiViewService\`).
4. **NuGet** – used to restore NuGet packages (`Newtonsoft.Json`).

## Restoring packages

Run the following command from the repository root or let Visual Studio restore automatically when the solution opens:

```bash
nuget restore DoThingsBot.sln
```

This creates a `packages` folder containing `Newtonsoft.Json` referenced by `packages.config`.

## Building

1. Open `DoThingsBot.sln` in Visual Studio.
2. Ensure the above prerequisites are installed so the referenced DLLs can be resolved.
3. Choose **Build > Build Solution** to compile. The resulting `DoThingsBot.dll` will appear under `bin/Debug` or `bin/Release` depending on configuration.

### Command line

If Visual Studio is installed with MSBuild available in `PATH`, you can build without opening the IDE:

```bash
msbuild DoThingsBot.sln /p:Configuration=Release
```

