# BlazingShop

Hello and thanks for dropping by!

And here's how you can run this application.

## 1. Install SQL Server & Entity Framework

Since we're using Microsoft SQL Server and Entity Framework Core in this application, you have to install these first.
You could also just search for Microsoft SQL Server 2022 and maybe also Azure Data Studio and download both.
Regarding Entity Framework, we need some tools you can install with the following command in the Package Manager Console:

`dotnet tool install --global dotnet-ef`

## 2. Update the ConnectionString

In the `appsettings.Development.json` file of the Server project, you will find the connection string to connect to your database.
If you're using SQL Server on the same machine then this should already work. Otherwise, I assume you know what you're doing, so don't forget to update the string.

## 3. Update the Database

To create the database with all the seeded data, make sure to change to the Server directory of this solution.

`cd ./Server`

Then you can run all the migrations of EF Core or update the database, respectively.

`dotnet ef database update`

## 4. Run the Application

And finally, you can run the app.

`dotnet watch run`

Happy coding!
