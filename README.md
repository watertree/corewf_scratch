# corewf_scratch

Simple project to demonstrate corewf compatibility issues between Windows and Linux/Mac whenever the entry point project targets netcoreapp3.1.  It fails on Linux/Mac because corewf will want to use WPF targets that do not exist outside of Windows.

In Mac OSX or Linux, run the following script to download assemblies prior to running the test

```powershell
./Update-CoreWf.ps1
```

To run the test:

```
cd Scratch.Tests
dotnet test
```
