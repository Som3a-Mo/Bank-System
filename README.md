# Bank System Application

This is a simple console-based bank system application developed in C#. The application allows clients, employees, and admins to perform banking-related tasks such as deposits, withdrawals, client management, and employee management. The system is built with a modular structure consisting of Client, Employee, and Admin modules, with each module having specific functionalities.

## Project Structure

The project is divided into three main modules:

- **Client Module**: Handles operations related to clients, including logging in, checking balance, deposits, withdrawals, and transfers.
- **Employee Module**: Allows employees to manage clients, including adding new clients, editing client information, and listing all clients.
- **Admin Module**: Extends the Employee module with additional functionalities like managing employees (adding, editing, and listing employees).

### Class Overview:

1. **Person**:
   - The base class that contains common properties such as `id`, `name`, and `password`.
   - Inherited by both `Client` and `Employee`.

2. **Client**:
   - Contains properties such as `balance` and methods to deposit, withdraw, check balance, and transfer funds.
   - Validates inputs like the minimum balance and ensures secure login with the correct password.

3. **Employee**:
   - Inherits from `Person` and includes properties like `salary`.
   - Can add, search, and manage client information.

4. **Admin**:
   - Inherits from `Employee` and adds the ability to manage employees.
   - Can add, search, and edit employee information.

5. **Validation**:
   - A static class used to validate input, such as name and password formatting.

6. **FileManager**:
   - Implements the `DataSourceInterface` to handle file operations for saving and retrieving data for clients, employees, and admins.

7. **Parser**:
   - Provides utility methods to parse data from text files into objects such as `Client`, `Employee`, and `Admin`.

8. **FilesHelper**:
   - Handles file-related operations like saving and retrieving data, clearing files, and managing last IDs.

9. **ClientManager**, **EmployeeManager**, and **AdminManager**:
   - Provide functionality for managing the flow of operations for clients, employees, and admins respectively, such as login, editing data, and viewing details.

10. **Screens**:
    - Manages the UI for the console application, such as login screens, menus, and application flow.

## Prerequisites

- .NET SDK (Version 5.0 or higher)
- C# IDE or text editor (Visual Studio recommended)
- Basic knowledge of C# and file I/O operations

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/Som3a-Mo/Bank-System.git
   ```
2. Open the project in Visual Studio or your preferred IDE.
3. Build the project to restore dependencies and compile the code.
4. Run the application:
   - The application starts by displaying a welcome screen, followed by a login prompt where the user can choose to log in as a client, employee, or admin.
## Running the Application
1. When you run the application, you'll be presented with three login options:

   - Client Login: Log in as a client to perform banking operations like deposit, withdrawal, and balance checking.
   - Employee Login: Log in as an employee to manage clients.
   - Admin Login: Log in as an admin to manage both clients and employees.
2. Each user can log in with their ID and password. If valid, they'll be directed to a menu with the relevant options for their role.

3. All operations, such as adding clients and employees, editing their details, and displaying information, are available through these menus.
4. Use id `1` & password `12345678` to login as **administrator**.
