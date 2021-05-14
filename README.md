# aspdotnet-projects

Create project lines:

dotnet --list-sdks  
dotnet new globaljson --sdk-version [version] --output [solution name]/[project name]  
dotnet new mvc [--no-https] --output [solution name]/[project name] --framework netcoreapp3.1  
dotnet new sln -o [solution name]

dotnet build  
dotnet run

Managing NuGet Packages

dotnet add package [name] --version x.x.x  
dotnet list package  
dotnet remove package [name]

Managing Tool Packages

dotnet tool uninstall --global dotnet [name (ex: -ef)]  
dotnet tool install --global-[name (ex: -ef)] --version x.x.x  
dotnet ef --help

Managing Client-Side Packages

dotnet tool uninstall --global Microsoft.Web.LibraryManager.Cli  
dotnet tool install --global Microsoft.Web.LibraryManager.Cli --version x.x.x

libman init -p cdnjs  
libman install twitter-bootstrap@[version] -d [project directory] wwwroot/lib/twitter-bootstrap

