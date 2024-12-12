# EmbeddedProjectApi

## Overview
EmbeddedProjectApi is an ASP.NET Core API designed to manage and control embedded systems such as esp and Rfid devices. The API integrates with SQL Server for data management and supports hardware simulation.

---

## Features

- API for Embedded Systems: Supports communication with embedded devices, such as Arduino or other microcontrollers.

- Modular Design: Easy to extend and adapt to specific hardware requirements.

- Built with .NET Core: Leveraging the power of ASP.NET Core for performance and scalability.

- Database Support: Integrated with SQL Server for efficient data storage and retrieval.

- Simulation Ready: Compatible with tools like MQTT protocols.

---

## Tech Stack

- Backend: ASP.NET Core 8

- Database: SQL Server

- Programming Language: C#

- Hardware Integration: Arduino Uno, Breadboard, DC Motor

---

## Getting Started

Prerequisites

1. .NET SDK ( Version 8.0 )


2. SQL Server installed locally or on a cloud service.


3. Arduino IDE and hardware ( Rfid , Rfid Tags ).

---

## Installation

### 1. Clone the repository:

   - git clone https://github.com/AdhamMo1/EmbededProjectApi.git  
   - cd EmbeddedProjectApi
    

### 2. Set up the database:

  - Update the connection string in appsettings.json.
  - Run the migration commands:
  - dotnet ef migrations add InitialCreate  
  - dotnet ef database update

### 3. Run the API:
   - dotnet run

### 4. Test the API using tools like Postman or Swagger UI.

---

### Endpoints:

- GET  /api/Student/GetStudent - Retrieve Student who Attended.

---

## Contributing

- Contributions are welcome! Feel free to open issues or submit pull requests to improve this project.

---

# Contact

- For any questions, feel free to reach out:
- Name: Adham Mohamed
- Email: adhmmohamed066@gmail.com
- LinkedIn: https://www.linkedin.com/in/adham-mohamed1

