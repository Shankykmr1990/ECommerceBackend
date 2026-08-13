# 🛒 E-Commerce Backend API

A clean and scalable **E-Commerce Backend REST API** built with **ASP.NET Core Web API**, following layered architecture and clean code principles.

> 🚧 **Project Status:** In Development  
> The project is being developed module-by-module. Each module is implemented and tested before moving to the next one.

---

## 🚀 Tech Stack

| Technology | Usage |
|---|---|
| C# | Programming Language |
| ASP.NET Core Web API | Backend / REST API |
| Entity Framework Core | ORM |
| SQL Server | Database |
| Swagger / OpenAPI | API Documentation & Testing |
| Dependency Injection | Dependency Management |
| Repository Pattern | Data Access |
| Service Layer | Business Logic |
| Git & GitHub | Version Control |

---

## 🏗️ Architecture

The project follows a layered architecture inspired by **Clean Architecture** principles.

```text
ECommerce
│
├── ECommerce.API
│   ├── Controllers
│   ├── Program.cs
│   └── appsettings.json
│
├── ECommerce.Application
│   ├── DTOs
│   ├── Interfaces
│   └── Services
│
├── ECommerce.Domain
│   └── Entities
│       ├── Product.cs
│       └── User.cs
│
└── ECommerce.Infrastructure
    ├── Data
    │   └── ApplicationDbContext.cs
    └── Repositories
```

### 🔄 Request Flow

```text
HTTP Request
      │
      ▼
 Controller
      │
      ▼
   Service
      │
      ▼
 Repository
      │
      ▼
 Entity Framework Core
      │
      ▼
  SQL Server
```

### Layer Responsibilities

**ECommerce.API**
- Handles HTTP requests and responses
- Contains API controllers
- Configures application services and dependency injection

**ECommerce.Application**
- Contains DTOs
- Contains interfaces
- Contains application/business logic
- Coordinates services and repositories

**ECommerce.Domain**
- Contains core business entities
- Independent from infrastructure and database implementation

**ECommerce.Infrastructure**
- Contains Entity Framework Core configuration
- Contains `DbContext`
- Contains repository implementations
- Handles database access

---

## ✅ Current Progress

### 🛍️ Product Module — Completed

- [x] Product Entity
- [x] Product DTO
- [x] Product Repository Interface
- [x] Product Repository Implementation
- [x] ApplicationDbContext
- [x] SQL Server Connection
- [x] EF Core Migration
- [x] Dependency Injection
- [x] Product Service
- [x] Get All Products
- [x] Get Product By ID
- [x] Create Product
- [x] Update Product
- [x] Delete Product
- [x] Swagger Testing

### 👤 User Module — In Progress

- [ ] User Entity
- [ ] User DTO
- [ ] User Repository
- [ ] User Service
- [ ] User CRUD APIs

### 🛒 Upcoming Modules

- [ ] Cart
- [ ] Order
- [ ] Payment
- [ ] Authentication
- [ ] JWT Authorization
- [ ] Role-Based Authorization
- [ ] Admin Features
- [ ] Validation
- [ ] Global Exception Handling
- [ ] Logging
- [ ] Security Improvements
- [ ] Performance Optimization

---

## 📡 Product API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/Products` | Get all products |
| `GET` | `/api/Products/{id}` | Get product by ID |
| `POST` | `/api/Products` | Create a product |
| `PUT` | `/api/Products/{id}` | Update a product |
| `DELETE` | `/api/Products/{id}` | Delete a product |

---

## 🧪 API Testing

The project uses **Swagger / OpenAPI** for API documentation and testing.

Run the application and open:

```text
/swagger
```

Example Product request:

```http
POST /api/Products
Content-Type: application/json
```

```json
{
  "name": "Laptop",
  "description": "Gaming Laptop",
  "price": 55000,
  "stock": 10,
  "imageUrl": "laptop.jpg"
}
```

---

## 🗄️ Database

The application uses **Microsoft SQL Server** with **Entity Framework Core**.

### Connection String

Configure your SQL Server connection in:

```text
ECommerce.API/appsettings.json
```

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

> Do not commit real production credentials, passwords, or secrets to GitHub.

---

## 🔄 Entity Framework Core Migrations

Create a migration:

```powershell
Add-Migration MigrationName
```

Update the database:

```powershell
Update-Database
```

---

## ⚙️ Getting Started

### Prerequisites

Make sure the following are installed:

- .NET SDK
- SQL Server / SQL Server Express / LocalDB
- Visual Studio or VS Code
- Git

### Clone the Repository

```bash
git clone YOUR_GITHUB_REPOSITORY_URL
```

### Open the Project

Open the solution:

```text
ECommerce.sln
```

### Configure Database

Update the connection string in:

```text
ECommerce.API/appsettings.json
```

### Apply Migrations

```powershell
Update-Database
```

### Run the Application

Run the API using Visual Studio or:

```bash
dotnet run
```

Then open Swagger:

```text
/swagger
```

---

## 🎯 Project Development Roadmap

The project is intentionally being developed one module at a time.

```text
┌─────────────┐
│   Product   │ ✅
└──────┬──────┘
       │
       ▼
┌─────────────┐
│    User     │ 🚧
└──────┬──────┘
       │
       ▼
┌─────────────┐
│    Cart     │ ⏳
└──────┬──────┘
       │
       ▼
┌─────────────┐
│    Order    │ ⏳
└──────┬──────┘
       │
       ▼
┌─────────────┐
│   Payment   │ ⏳
└──────┬──────┘
       │
       ▼
┌──────────────────────┐
│ Authentication / JWT │ ⏳
└──────────────────────┘
```

---

## 🧠 Concepts Demonstrated

This project is designed to demonstrate practical backend development concepts including:

- RESTful API Development
- ASP.NET Core Web API
- Clean Architecture Principles
- Layered Architecture
- Dependency Injection
- Repository Pattern
- Service Layer
- DTO Pattern
- Entity Framework Core
- SQL Server
- Database Migrations
- CRUD Operations
- Swagger / OpenAPI
- Authentication & Authorization
- JWT
- Role-Based Access Control

---

## 🔐 Security

Security-related features will be added in later stages.

Planned features include:

- Password Hashing
- JWT Authentication
- Role-Based Authorization
- Input Validation
- Global Exception Handling
- Secure Configuration
- API Security Best Practices

---

## 📌 Development Philosophy

The project is intentionally developed **step-by-step** rather than building all modules at once.

Each module follows:

```text
Entity
  ↓
DTO
  ↓
Repository
  ↓
Service
  ↓
Controller
  ↓
API Testing
  ↓
Module Complete ✅
```

This approach keeps the project understandable, testable, and maintainable.

---

## 👨‍💻 Author

### Shashank Kumar

**Backend Developer**

**Skills:** C# • ASP.NET Core • Web API • Entity Framework Core • SQL Server • REST APIs • Node.js

---

## ⭐ Future Improvements

Planned improvements as the project grows:

- Pagination
- Searching
- Filtering
- Sorting
- FluentValidation
- Global Exception Middleware
- Structured Logging
- Caching
- Performance Optimization
- Unit Testing
- Integration Testing
- Docker
- CI/CD
- Cloud Deployment

---

⭐ If you find this project useful, consider giving the repository a star!
