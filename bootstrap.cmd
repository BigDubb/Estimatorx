@echo off
Nuget.exe restore "Code\Source\Estimatorx.sln"

NuGet.exe install MSBuildTasks -OutputDirectory .\Tools\ -ExcludeVersion -NonInteractive
NuGet.exe install xunit.runners -OutputDirectory .\Tools\ -ExcludeVersion -NonInteractive
