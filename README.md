# About The Project
FileParser is a command-line utility designed for data management and processing. It empowers users to  load structured data files, such as JSON or CSV, 
into memory and execute data manipulation tasks with supported commands. This application supports concurrent loading of multiple files, offering users 
the ability to switch between datasets during the processing workflow.
# Getting Started
### Downloading the source code
You can download the source code for this application by clicking the "Clone or download" button on the GitHub repository page and then selecting 
"Download ZIP." Extract the contents of the ZIP file to a location of your choice.
### Building the Application
1. Run the following command to restore the NuGet packages:
```
dotnet restore
```
2. Run the following command to build the application:
```
dotnet build
```
### Running the Application
4. Open a command prompt or terminal window and navigate to the directory where you extracted the source code.
5. Run the following command to start the application:
``` 
dotnet run
```
The application should now be running, to use the application follow the ons-screen instructions or type --help.
# Usage
### User Interface
Applications supports various commands:  
**upload**
```
upload [-collection | --c] <collection_name> <source>
```
Upload commad uploads file from _source_, which is a URL or dir path into a memory, 
data stored in file must match given _collectionname_ supported by the application.  
**download**
```
download [-name | --n] <name> <path>
```
Downloads file from the memory, _name_ is file name that has been uploaded,
_path_ is a directory path you want the file to be downlaoded.  
**greater**
```
greater [-than | --t] <property_name> <value>
```
Greater command parses a file you're currently working on,
and filters it by comparing _propertyname_ to a _value_,
returning objects with greater property values.  
**smaller**
```
smaller [-than | --t] <property_name> <value>
```
Smaller command parses a file you're currently working on,
and filters it by comparing _propertyname_ to a _value_, 
returning objects with smaller property values.  
**switch**
```
switch [-name | --n] <file_name> 
```
Switches a working directory into a directory
specified by a _filename_.  
  
--help - displays help menu  
--exit - exits the application  



### Code


# Contributing
If you wish to contribute to this project, please feel free to create a pull request with your changes.
# License
This project is licensed under the MIT License - see the LICENSE file for details.

