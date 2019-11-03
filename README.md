Steps to build application
1.Build ng App
naviagte to \TimeSheetReconciliation\Web\SPA\portal
  1.npm install   this command to be run only once when the application is cloned
  
  2.ng build    this command for dev build
  2.ng build --prod   this command for prod build
  
2.Build dotnet API
  Click debug of VS CODE to run app


Command to create publish package of application
dotnet publish -r win-x64 -c Release --self-contained
Above command will generate artifacts at "\TimeSheetReconciliation\Web\bin\Release\netcoreapp2.2\win-x64\publish"
Find exe, double click to run the application.
