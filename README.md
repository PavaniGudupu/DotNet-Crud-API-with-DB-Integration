This project is a Product Management Web API built with ASP.NET Core (.NET 8 LTS) and SQL Server Express 2022, using Entity Framework Core for ORM.
It demonstrates clean architecture principles, DTO usage, validation, and standardized API responses — mirroring Node.js + PostgreSQL workflows but implemented in the .NET ecosystem.
---
🚀 Features
✅ CRUD APIs for Product management (GET, POST, PUT, DELETE)

✅ Entity Framework Core 8 integration with SQL Server

✅ DTOs + Validation for clean input handling

✅ Swagger/OpenAPI enabled for API documentation

✅ Standardized API Responses with success/failure wrappers

✅ Separation of Concerns (Controllers, Models, DTOs, Data, Helpers)

---

🛠️ Tech Stack
  - Backend: ASP.NET Core Web API (.NET 8 LTS)

  - Database: SQL Server Express 2022

  - ORM: Entity Framework Core 8
  
  - IDE: Visual Studio 2022 Community

  - Tools: SSMS v20, NuGet Package Manager

---


📂 Project Structure


    /Controllers     → API endpoints (ProductController)
    /Models          → Entity classes (Product)
    /DTOs            → Data Transfer Objects (ProductDto)
    /Data            → DbContext (AppDbContext)
    /Helpers         → ApiResponse wrapper
    /Migrations      → EF Core migrations

---

▶️ Getting Started

1️⃣ Prerequisites
  - Install SQL Server Express 2022

  - Install SSMS v20

  - Install Visual Studio 2022 Community with workloads:

  - ASP.NET and web development

  - .NET desktop development

Install .NET 8 SDK (LTS)

2️⃣ Setup
Clone the repository:

    bash
    git clone https://github.com/username/product-api-dotnet.git
  Configure database in SSMS:

    sql
    CREATE DATABASE ProductDb;
Update appsettings.json:

    json
    "ConnectionStrings": {
      "DefaultConnection": "Server=DESKTOP-53LD908\\SQLEXPRESS2022;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;"
    }
Run migrations:

    powershell
    Add-Migration InitialCreate
    Update-Database
Start the API:

    bash
    dotnet run

---


📌 API Endpoints


  | Method | Endpoint | Description |
  | --- | --- | --- |
  | GET | ``/api/product`` | Fetch all products |
  | POST | ``/api/product`` | Add new product (DTO) |
  | PUT | ``/api/product/{id}`` | Update product by ID |
  | DELETE | ``/api/product/{id}`` | Delete product by ID |

  ----


  👩‍💻 Author
Pavani Gudupu  
Customer Support Executive @ Venx IT Solutions | Backend Developer | B.Tech in Computer Science & Data Science
