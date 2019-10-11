# Getting MiniCover to work on Mono/macOS:

```bash
msbuild /restore
cd tools
dotnet minicover instrument --workdir ../ --assemblies nunit2/bin/Debug/net472/console.dll --sources console/*.cs

# you may need to modify the nuget console runner package version
mono ~/.NuGet/packages/nunit.consolerunner/3.10.0/tools/nunit3-console.exe nunit2/bin/Debug/net472/nunit2.dll

dotnet minicover htmlreport --workdir ../
open ../coverage-html/index.html
```


