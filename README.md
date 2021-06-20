# _Animal Shelter API_

#### _An animal shelter C# API_

#### By _James Wyn_

## Description
An API that allows users to View, Add, Edit, and Delete animals from an imaginary Animal Shelter's archive. A user may interact with the in-use version of the API using Postman or the built-in Swagger UI.

## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A command line interface like Terminal or GitBash to run and interact with the app.
* [MySQL Workbench](https://www.mysql.com/products/workbench/)
* (Optional)[Postman](https://www.postman.com/downloads/)

### Installation
1. Clone the repository: `$ git clone https://github.com/Thisisjameswyn/AnimalShelter.Solution`
2. Navigate to the `AnimalShelter.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base

### Connecting project to database via appsettings.json
1. In the production folder `AnimalShelter.Solution/AnimalShelter` create a file called `appsettings.json`
2. Add the following code:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server={YOUR_SERVER};Port={YOUR_PORT};database={YOUR_SCHEMA_NAME};uid=root;pwd={YOUR_PASSWORD};"
  }
}
```

   * Fill in the desired name of your server, port, schema and MySQL Workbench password, omitting the curly braces

### To run the API:
1. Navigate to `AnimalShelter.Solution/AnimalShelter` in your command line
2. Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
3. Run the command `dotnet build` to build the project and its dependencies into a set of binaries
4. Run the command `dotnet ef database update` to create database and populate tables
5. If you wish to update the database with any changes to the code, run the command `dotnet ef migrations add {MigrationName}` and  again `dotnet ef database update`
6. Finally, run the command `dotnet run` to run the project!
7. Note: `dotnet run` also restores and builds the project, so you can use this single command to start the app

## API Documentation
#### Swagger
1. After launching the project with `dotnet run` gain access to the API with Swagger by visiting `localhost:5000/swagger`
#### Postman
1. Explore API endpoints using Postman
### API Endpoints
Request URL `https://localhost:5000`

#### HTTP Request Structure for Animals
```
GET /api/animals
POST /api/animals
GET /api/animals/{id}
PUT /api/animals/{id}
DELETE /api/animals/{id}

Random animal /api/animals/random
```
#### Sample Request URL
Using animal ID
```
http://localhost:5000/api/Animals/2
```
-Additionally you can search by-

Species:
```
http://localhost:5000/api/animals?species=dog
```
Age:
```
http://localhost:5000/api/Animals?age=4
```
Gender:
```
http://localhost:5000/api/Animals?gender=female
```
Name:
```
http://localhost:5000/api/Animals?name=Claire
```
#### Sample JSON Response for Animals
```
  { 
    "animalId" :	5,
    "name" :	"Bob",
    "species" :	"Chicken",
    "age"	: 1,
    "gender" : "Female",
  }
```

## Known Bugs
There were no bugs found

## Technologies Used
* ASP .NET Core MVC
* C#
* VS Code
* MySQL Workbench
* MySQL
* Entity Framework Core
* LINQ
* Swagger
* Swashbuckle.AspNetCore 
* Postman
* AspNetCore Mvc Versioning

### License

MIT

Copyright (c) 2021 _James Wyn_