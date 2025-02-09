# React + TypeScript + .NET 8 CRUD App

This project is a simple **CRUD application** built using **React (TypeScript) and .NET 8 Web API**. It includes key features such as **CORS handling, Fluent Validation, Mapster for object mapping, Global Exception Handling, Entity Framework Core setup, and an SQLite database**.

## 🚀 Features
- 📝 **CRUD Operations** (Create, Read, Update, Delete) on movies
- 🌐 **React with TypeScript** for frontend development
- 🔗 **.NET 8 Web API** as the backend
- 🛠 **Entity Framework Core** with SQLite database
- ✅ **Fluent Validation** for request validation
- 🔄 **Mapster** for efficient object mapping
- ⚠️ **Global Exception Handling**
- 🔄 **CORS Configuration** to allow cross-origin requests

## 🏗 Tech Stack
- **Frontend:** React, TypeScript, Axios, React Router
- **Backend:** .NET 8, ASP.NET Core Web API
- **Database:** SQLite with Entity Framework Core

## 📂 Project Structure
```
/MoviesApp
│── frontend/     # React + TypeScript (UI & API calls)
│── backend/      # .NET 8 Web API (CRUD endpoints, DB setup)
│── README.md     # Project documentation
```

## 🔧 Setup & Installation

### 1️⃣ Clone the Repository
```sh
git clone https://github.com/yourusername/react-dotnet8-crud.git
cd react-dotnet8-crud
```

### 2️⃣ Backend Setup (API)
```sh
cd backend
# Install dependencies
dotnet restore

# Run the API
dotnet run
```
The API will start at `http://localhost:5000`

### 3️⃣ Frontend Setup (React)
```sh
cd frontend
# Install dependencies
npm install

# Run the React app
npm start
```
The React app will run at `http://localhost:3000`

## 🎯 API Endpoints
| Method | Endpoint       | Description         |
|--------|---------------|---------------------|
| GET    | /api/movies   | Get all movies     |
| GET    | /api/movies/{id} | Get a movie by ID |
| POST   | /api/movies   | Add a new movie    |
| PUT    | /api/movies/{id} | Update a movie   |
| DELETE | /api/movies/{id} | Delete a movie   |

## 🛠 Tools & Libraries Used
- **React** (UI framework)
- **Axios** (HTTP requests)
- **React Router** (Navigation)
- **.NET 8 Web API** (Backend)
- **Entity Framework Core** (ORM for SQLite)
- **FluentValidation** (Request validation)
- **Mapster** (Object mapping)
- **CORS Middleware** (Cross-origin requests)

---
Made with ❤️ by **Abdelrahman Ali** 🚀

