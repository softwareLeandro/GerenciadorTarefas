![Energy Boost](https://media4.giphy.com/media/26ufnwz3wDUli7GU0/giphy.gif)

# GerenciadorTarefas

# 🗂️ Task Manager – .NET Console Application

A simple and extensible task manager built with **C# and .NET**, running in the terminal.  
It features basic task operations and stores data persistently in a local JSON file.  
The project was created as a hands-on learning exercise and serves as a foundation for exploring the .NET ecosystem on macOS.

---

## ✨ Features

- ✅ List all tasks
- ✅ Add a new task
- ✅ Mark tasks as completed
- ✅ Delete tasks
- ✅ Data persistence using a `tarefas.json` file

---

## 🛠️ Tools & Technologies

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [JetBrains Rider (Simplified .NET UI)](https://www.jetbrains.com/rider/)
- [Warp Terminal](https://www.warp.dev/) (optional, used for running commands)
- macOS (tested on **MacBook M2 Pro** with Apple Silicon)

---

## 💻 Setup Instructions

### 1. Install .NET SDK (macOS)

Using Homebrew:

# bash
brew install --cask dotnet-sdk

---

Project Creation (Done via Rider)
This project was created using:
✅ JetBrains Rider (new .NET simplified interface)
✅ Warp Terminal for running CLI commands
Steps followed:
Open JetBrains Rider and click New Solution
Select Console Application (.NET)
Name the project GerenciadorTarefas
Uncheck Docker support (optional)
Open the built-in terminal or use Warp and run: dotnet run

---

GerenciadorTarefas/
├── Program.cs           # Main menu logic, methods, and JSON file handling
├── Tarefa.cs            # Task model with properties and display method
├── tarefas.json         # Auto-generated JSON file with task data
├── GerenciadorTarefas.csproj
└── README.md            # This documentation file

---

Next Steps & Ideas
This project is intentionally kept simple, but it can be expanded further with the following features:
🗓️ Add created/completed dates to tasks
✏️ Edit existing tasks
🔍 Add keyword-based search
🏷️ Add tags or categories
☁️ Switch from JSON to a real database (e.g., SQLite or PostgreSQL)
🌐 Turn it into a REST API (ASP.NET Core)
🖥️ Build a GUI (e.g., WPF, WinForms, MAUI, or Blazor)
☁️ Deploy to the cloud

---

Developer Environment
This project was built using:
MacBook M2 Pro (Apple Silicon)
Warp Terminal for smooth CLI interaction
JetBrains Rider (modern, minimal .NET UI experience)
.NET 9 SDK

![Task Manager Fun](https://media4.giphy.com/media/v1.Y2lkPTc5MGI3NjExMDV5cXV1M3psaWxzNGp2YnZ0NHcweWJod3k0MHJ6b3RscDJteWp1cSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/4oHyOIBIt57ag/giphy.gif)
![Celebration](https://media2.giphy.com/media/v1.Y2lkPTc5MGI3NjExa29pZjJqeWFrcXJyc3dhbGpkaW43Y2o0a3E2MzB0d3VkaGpvMThjNCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/a93jwI0wkWTQs/giphy.gif)

