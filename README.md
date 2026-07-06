# DailyLifeApi

DailyLifeApi is a simple ASP.NET Core Web API project developed to manage daily life activities through CRUD operations.  
The project includes four independent tables and provides API endpoints for creating, reading, updating, and deleting records.

## 🚀 Features

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server Database
- Code First Migration
- Swagger UI Documentation
- CRUD Operations
- 4-table API structure

## 🧩 Tables

The project contains the following main tables:

- Ideas
- Moods
- Shopping Items
- Water Trackings

## 🛠️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / Swashbuckle
- Visual Studio
- C#

## 📦 NuGet Packages

The following NuGet packages are used in this project:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Swashbuckle.AspNetCore

## 🔄 CRUD Operations

Each table supports basic CRUD operations:

- GET: List records
- GET by ID: Get a single record
- POST: Add a new record
- PUT: Update an existing record
- DELETE: Delete a record

## 📁 Project Structure

```text
DailyLifeApi
│
├── Controllers
├── Data
├── Migrations
├── Models
├── appsettings.json
├── Program.cs
└── DailyLifeApi.http
