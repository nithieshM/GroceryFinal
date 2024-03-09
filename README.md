# Grocery Web Application

The **Grocery Web Application** is a .NET Core 8 MVC Application designed to manage grocery items and perform CRUD operations utilizing SQL Server as its backend. This application provides a user-friendly interface for users to manage their grocery inventory efficiently.

## Features

- **CRUD Operations**: Perform Create, Read, Update, and Delete operations on grocery items.
- **User-Friendly Interface**: Intuitive design for easy navigation and interaction.

## Technologies Used

- **.NET Core 8**: Powerful and flexible framework for building web applications.
- **MVC Architecture**: Utilizes the Model-View-Controller pattern for structured development.
- **SQL Server**: Robust relational database management system for storing and managing data.
- **C# Programming Language**: Primary language used for development, providing strong typing and modern features.

## Setup Instructions

To set up the Grocery Web Application locally, follow these steps:

1. **Clone the Repository**: Clone the repository to your local machine using the following command:

    ```
    git clone https://github.com/yourusername/Grocery.git
    ```

2. **Database Setup**:
    - Ensure you have SQL Server installed and running.
    - Update the connection string in the `appsettings.json` file to point to your SQL Server instance.
    - Create a new migration with the command `add-migration InitialCreate` and update the database before building running the application using `update-database`.

3. **Build and Run**:
    - Open the solution in Visual Studio or your preferred IDE.
    - Build the solution to restore dependencies and compile the application.
    - Run the application to launch the Grocery Web Application.

4. **Navigate**:
    - Once the application is running, navigate to the appropriate URL in your web browser to access the Grocery Web Application.

## Usage

- **Login and Register**: Login and Register pages.
- **CRUD Operations**: Add, edit, or delete grocery items as needed.
- **Manage Relationships**: Utilize foreign key relationships to manage linked items effectively.

## License

The Grocery Web Application is open-source software licensed under the [MIT License](LICENSE).

