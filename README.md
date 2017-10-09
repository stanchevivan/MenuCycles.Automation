# Menu Cycles Automation Tests

## Structure

The project has the following structure:

```
MenuCycle.Automation
	|_ MenuCycle.Data (.netStandard 2.0)
	|	|_ Generators
	|	|_ Models
	|	|_ Repositories
	|	|_ Services
	|_ MenuCycle.Tests (.Net4.6.2)
		|_ Features
		|_ PageObjects
		|_ Steps
		|_ Support
		|_ App.Config (and transformations)
```		

## Details

The Solution was re-created using .netStandar 2.0 as starting point to avoid referencing issues. A Jenkins file is also included, so creating a Pipeline in Jenkins and referencing this file should be enough to be up and running on any Jenkins.

### MenuCycle.Data 

The data project was created using EntityFrameworkCore 2.0. In order to use it sucessfully, you need to install the latest versions of .Net Core SDK (described in Requirements section). As this is all new technology, there are a few incompatibility issues that needs to be addressed manually.

### MenuCycle.Tests

A standard .Net project containing the tests using Fourth frameworks. Please note, although Reporting framework is also added, it is NOT compatible with Mac for now. It doesn't generate the .json file and you can only see an error if you DEBUG the test. Meaning if you simply RUN it won't cause any issue. It is hightly recommended that you remove this package from the solution so you can debug your tests properly and add a step on your Jenkins file to include the package so jenkins can generate the report and publish the html version.


## Requirements

* [Visual Studio 2017](https://www.visualstudio.com/downloads/)
* [.Net Core 2.0 SDK](https://www.microsoft.com/net/download/core)
* [NuGet > 4.0](https://www.nuget.org/downloads)
* [Windows Only: Microsoft .Net Framework 4.6.2](https://www.microsoft.com/en-us/download/confirmation.aspx?id=53321)


## Extra

*[Entity Framework Core](https://github.com/aspnet/EntityFrameworkCore)
	