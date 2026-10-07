# Pharmacy Management System

A desktop-based **Pharmacy Management System** developed using **C# Windows Forms** and **SQL Server**. The application is designed to help manage pharmacy operations, including medicines, inventory, users, and day-to-day pharmacy management.

## Overview

The Pharmacy Management System provides a centralized desktop application for managing pharmacy-related information.

The project focuses on combining a Windows Forms user interface with a SQL Server database to organize and manage pharmacy data efficiently.

## Features

* 💊 Medicine management
* 📦 Inventory management
* 👤 User management
* 🔐 Role-based access
* 🗄️ SQL Server database integration
* 🖥️ Windows Forms desktop interface
* 📋 Pharmacy data management
* 🔎 Organized record management

## User Roles

The application supports different user roles for managing access to pharmacy functionality.

### Administrator

The administrator can manage system-level operations and pharmacy records.

### Pharmacist

The pharmacist can work with pharmacy-related records and day-to-day management operations.

> The exact permissions available to each role depend on the application's configured database and implementation.

## Tech Stack

| Technology         | Purpose                 |
| ------------------ | ----------------------- |
| C#                 | Application development |
| Windows Forms      | Desktop user interface  |
| SQL Server         | Database                |
| Visual Studio 2022 | Development environment |

## Project Structure

```text
Pharmacy-Management-System/
│
├── Project/
│   └── C# application files
│
├── Main.sln
├── .gitattributes
├── .gitignore
└── README.md
```

## Getting Started

### Prerequisites

Make sure you have:

* Windows
* Visual Studio 2022
* .NET desktop development workload
* SQL Server
* SQL Server Management Studio (SSMS), if needed for database management

### Installation

1. Clone the repository:

```bash
git clone https://github.com/BasimZahid/Pharmacy-Management-System.git
```

2. Open the solution:

```text
Main.sln
```

in **Visual Studio 2022**.

3. Set up the required SQL Server database.

4. Configure the application's database connection string for your local SQL Server instance.

5. Build the solution.

6. Run the application from Visual Studio.

> **Note:** The database connection string may need to be changed depending on your SQL Server instance and local configuration.

## Database

The application uses **SQL Server** for persistent data storage.

The database handles information required by the pharmacy management system, including pharmacy records and user-related data.

For local development, configure the application's connection string to point to your SQL Server instance.

## Screenshots

Add screenshots of the application here to make the repository easier to understand.

Recommended screenshots:

```text
screenshots/
├── login.png
├── dashboard.png
├── medicines.png
├── inventory.png
└── users.png
```

Then reference them in this README:

```markdown
![Login](screenshots/login.png)

![Dashboard](screenshots/dashboard.png)

![Medicine Management](screenshots/medicines.png)

![Inventory](screenshots/inventory.png)
```

## What I Learned

This project provided practical experience with:

* C# programming
* Windows Forms development
* SQL Server integration
* CRUD operations
* Database-driven applications
* Role-based application access
* Desktop UI development
* Connecting application logic with persistent data

## Future Improvements

Possible future improvements include:

* Improved UI/UX
* Advanced medicine search
* Low-stock notifications
* Expiry-date alerts
* Sales and purchase tracking
* Invoice generation
* Advanced reports and analytics
* Database backup and restore
* More granular user permissions

## Author

**Basim Zahid**

GitHub: [@BasimZahid](https://github.com/BasimZahid)

---

⭐ If you find this project useful, feel free to explore the repository.
