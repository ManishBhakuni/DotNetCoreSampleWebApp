dotnet restore;
nuget restore;
dotnet restore --packages .\packages;
nuget restore -PackagesDirectory .\packages;
dotnet publish .\WebAPITests -o ..\build_tests --framework netcoreapp1.1;
ls;
.\packages\opencover\4.6.519\tools\OpenCover.Console.exe -target:"C:\Program Files\dotnet\dotnet.exe" -targetargs:"vstest WebAPITests.dll" -targetdir:"build_tests" -oldStyle -register:user -output:"_CodeCoverageResult.xml" -filter:"+[WebAPI]*";
.\packages\ReportGenerator\2.5.10\tools\ReportGenerator.exe "-reports:_CodeCoverageResult.xml" "-targetdir:_CodeCoverageReport";
