# EmbeddedProjectApi

## Overview
EmbeddedProjectApi is an ASP.NET Core API designed to manage and control embedded systems such as Arduino-based devices. The API integrates with SQL Server for data management and supports hardware simulation.

---

## Table of Contents
1. [Project Structure](#project-structure)
2. [Features](#features)
3. [Installation](#installation)
4. [Usage](#usage)
5. [API Endpoints](#api-endpoints)
6. [Contributing](#contributing)
7. [License](#license)

---

## Project Structure

```plaintext
EmbeddedProjectApi/
├── Controllers/           # API Controllers
│   └── DevicesController.cs
├── Models/                # Data Models
│   └── Device.cs
├── Data/                  # Database Context
│   └── AppDbContext.cs
├── Services/              # Business Logic
│   └── DeviceService.cs
├── Migrations/            # Database Migrations
├── Properties/            # App Configurations
│   └── launchSettings.json
├── appsettings.json       # Application Settings
├── Program.cs             # Application Entry Point
├── Startup.cs             # Middleware and Service Configurations
└── README.md              # Documentation
