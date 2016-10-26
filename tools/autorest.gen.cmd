setlocal
set specFile=%1
set namespace=%2
set autoRestVersion=%3
set generateFolder=%4
set header=%5
set packageName=autorest

if [%header%]==[] set header=MICROSOFT_MIT
if "%autoRestVersion%" gtr "0.17.0-Nightly20160707" set packageName=AutoRest

set source=-Source https://www.myget.org/F/autorest/api/v2

set repoRoot=%~dp0..
:set autoRestExe=%repoRoot%\packages\autorest.%autoRestVersion%\tools\AutoRest.exe
set autoRestExe=C:\Code\autorest\src\core\AutoRest\bin\Debug\net451\win7-x64\AutoRest.exe
set simplifier=%repoRoot%\tools\CodeSimplifier\CodeSimplifier.exe

%repoRoot%\tools\nuget.exe install %packageName% %source% -Version %autoRestVersion% -o %repoRoot%\packages -verbosity quiet

@echo on
%autoRestExe% -Modeler Swagger -CodeGenerator Azure.CSharp -Namespace %namespace% -Input %specFile% -outputDirectory %generateFolder% -Header %header% %~6

%simplifier% %generateFolder% %generateFolder%
@echo off
endlocal
