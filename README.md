# corewf_scratch

Simple project to demonstrate corewf compatibility issues between Windows and Linux/Mac based on the entry point's project's targeting of netcoreapp3.1, which corewf will want to use WPF targets that do not exist outside of windows.

In Mac OSX or Linux, run the following script to download assemblies prior to running the test

```powershell
./Update-CoreWf.ps1
```

To run the test:

```
cd Scratch.Tests
dotnet test
```
