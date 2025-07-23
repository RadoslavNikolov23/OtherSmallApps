DEA Program (.NET Windows Forms)
===============================

Overview:
---------
DEA Program is a legacy Windows Forms application built using .NET Framework 4.7, serving as a small prototype for a larger internal system. 
While developed for fun and experimentation, it features a modular, modern architecture and showcases fundamental functionality for user and data management.

The application connects to a PostgreSQL database and supports user authentication, role-based access control, and entity management (Persons and Vehicles).

Architecture:
-------------
The solution is structured using a modular architecture:
- **DEA_Program**: Main Console project
- **DEA_Program.Common**: Shared resources (constants, enums, helpers)
- **DEA_Program.Console**:  Main Windows Forms UI project
- **DEA_Program.Data**: Database access and context
- **DEA_Program.Model**: Entity models and data transfer objects

Features:
---------
- **User Authentication**: Login and registration support
- **Role-Based Access**:
  • **Admin**: Manage user roles, view all users  
  • **Regular User**: Register persons/vehicles, perform inquiries
- **Person & Vehicle Registration**: Register individuals and vehicles (linked to a driver)
- **Inquiry Panel**: Search for a person or vehicle, or by a specific date a customs check was performed

Technologies:
-------------
- .NET Framework 4.7
- Windows Forms (WinForms)
- PostgreSQL (Relational Database)

Purpose:
--------
This application was created as a lightweight proof-of-concept for exploring a potential design for a more comprehensive system at work. It demonstrates separation of concerns and a maintainable codebase using a layered architecture.

Disclaimer:
-----------
While the project uses a clean architectural layout, it is still a legacy-style WinForms application and may lack some modern practices seen in WPF or web development. It is intended for educational and internal experimentation purposes only.

Author:
-------
Radoslav Nikolov
