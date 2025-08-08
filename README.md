# 👋 Hi there!

Welcome to my project! This is the backend API for the Fitness Tracker App, built with .NET 8 following a clean, modular Onion Architecture. It powers user authentication, workout management, and workout type data for the app.

---

## 📦 Project Structure

This repository contains the backend API for the Fitness Tracker app.  
👉 The **frontend** is located in a separate repository: [Fitness Tracker Frontend](https://github.com/Peledew/fitness-tracker-client)

---

## 🚀 Features

- ✅ User registration, login, and JWT-based authentication
- 🛡️ Authorization and role-based access control
- 🏋️‍♀️ CRUD operations for workouts, workout types and users
- 📊 Weekly workout statistics with filtering by month/year
- 📁 Clean layered Onion Architecture for maintainability
- 🔧 AutoMapper integration for DTO mapping

---

## 📚 Technologies Used

- 🟢 **.NET 8**
- 🧱 **Onion Architecture**
- 📦 **Entity Framework Core** with SQL Server
- 🔐 **JWT Authentication**
- 🔄 **AutoMapper**
- ⚙️ **Dependency Injection**

---

## 💡 Additional Notes

- 🧠 Modular and maintainable code structure with clear separation of concerns
- 📊 Efficient querying with SQL, LINQ and EF Core optimizations
- 🔒 Secure authentication with JWT and custom user services
- 🚀 Ready for deployment with environment-based configuration

---

## ⚙️ Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

---

### 📥 Installation & Running

```bash
git clone https://github.com/Peledew/fitness-tracker-server.git
cd fitness-tracker-server
dotnet restore
dotnet build
dotnet ef database update
dotnet run
