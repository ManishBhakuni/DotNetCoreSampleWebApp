dotnet restore;
nuget restore;
dotnet restore --packages .\packages;
nuget restore -PackagesDirectory .\packages;
dotnet publish .\GoogleMD.api.tests -o ..\build_tests --framework netcoreapp1.1;
ls;
.\packages\opencover\4.6.519\tools\OpenCover.Console.exe -target:"C:\Program Files\dotnet\dotnet.exe" -targetargs:"vstest GoogleMD.api.tests.dll" -targetdir:"build_tests" -oldStyle -register:user -output:"_CodeCoverageResult.xml" -filter:"+[GoogleMD.api]*";
.\packages\ReportGenerator\2.5.9\tools\ReportGenerator.exe "-reports:_CodeCoverageResult.xml" "-targetdir:_CodeCoverageReport";
