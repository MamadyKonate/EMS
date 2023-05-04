# dotnetBuild

## Repository description

A sample repository that demonstrates building and testing a C# .NET application using a GitHub actions workflow. There are two GitHub actions workflows:  

* [dotnet.yml](.github/workflows/dotnet.yml) builds and tests the sample project using [dotnet build CLI](https://learn.microsoft.com/.en-us/dotnet/core/tools/)
* [superlinter.yml](.github/workflows/superlinter.yml)  lints the code in the repository using the GitHub action [Super-Linter](https://github.com/marketplace/actions/super-linter).  

Note: The [dotnet.yml](.github/workflows/dotnet.yml) workflow explicitly calls the dotnet restore command, but in most cases you don't need to explicitly do this, as it is implicitly called by build, test, publish and restore. I call it in this workflow to demonstrate the --no-restore and --no-build options for build and test respectively.

### Additional tasks to explore

There are a number of modifications that you could make to the sample here and I encourage you to explore the dotnet CLI [documentation](https://learn.microsoft.com/en-us/dotnet/core/tools/) further. You should consider trying to:  

* Break the build and test into separate jobs with test depending on a successful build job completing.  
* Build different configurations (release and debug).
* Output and upload [test](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test) logs (trx and HTML formats supported).
* If the buld and test jobs are successful then use the CLI dotnet [publish](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-publish) command to publish a release build for deployment or hosting.  
* If your own project builds a library you could use the CLI dotnet [pack](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-pack)  

I recommend that you fork the repository and try the dotnet CLI at the command-line locally on your PC first before modifying the workflow.  

Most of all __*play around and have fun*__.  

[![.NET](https://github.com/LYITComputing/dotnetBuild/actions/workflows/dotnet.yml/badge.svg)](https://github.com/LYITComputing/dotnetBuild/actions/workflows/dotnet.yml)  
[![Super-Linter](https://github.com/LYITComputing/dotnetBuild/actions/workflows/superlinter.yml/badge.svg)](https://github.com/LYITComputing/dotnetBuild/actions/workflows/superlinter.yml)
