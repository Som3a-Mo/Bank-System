
namespace Bank_System
{
    internal class AdminManager
    {
        public static Admin login(int id, string password)
        {
            Admin admin = FilesHelper.getAdmin(id);
            if (admin == null)
            {
                Console.WriteLine("This Id is Uncorrect");
                return admin;
            }
            if (password != admin.Password)
            {
                Console.WriteLine("The password is Uncorrect");
                return null;
            }
            return admin;
        }

        private static void printAdminMenu()
        {
            Console.WriteLine("1. Add a new employee");
            Console.WriteLine("2. List all employees");
            Console.WriteLine("3. Search for an employee");
            Console.WriteLine("4. Edit employee informatio");
            Console.WriteLine("5. Logout");
        }

        private static void newEmployee(Admin admin)
        {
            Employee employee = new Employee();
            int id = FilesHelper.employeeIdGenerator();
            employee.setId(id);
            string password = Console.ReadLine();
            bool validPassword = employee.setPassword(password);

            while (!validPassword)
            {
                password = Console.ReadLine();
                validPassword = employee.setPassword(password);
            }

            string name = Console.ReadLine();
            bool validName = employee.setName(name);
            while (!validName)
            {
                name = Console.ReadLine();
                validName = employee.setName(name);
            }

            double salary = double.Parse(Console.ReadLine());
            bool validBalance = employee.setSalary(salary);
            while (!validBalance)
            {
                salary = double.Parse(Console.ReadLine());
                validBalance = employee.setSalary(salary);
            }
        }
        private static void searchForEmployee(Admin admin)
        {
            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());
            Employee employee = FilesHelper.getEmployee(id);
            if (employee == null)
            {
                Console.WriteLine("This Employee is not exist");
                return;
            }
            Console.WriteLine($"The Employee with id: {id}, his name is: {employee.Name}," +
                $" his Salary: {employee.Balance}");
        }
        private static void editEmployeeInfo(Admin admin)
        {
            Console.WriteLine("Enter Employee id: ");
            int id = int.Parse(Console.ReadLine());
            Employee employee = FilesHelper.getEmployee(id);
            if (employee == null)
            {
                Console.WriteLine("This Employee is not exist");
                return;
            }
            string name = Console.ReadLine();
            bool validName = Validation.IsValidName(name);
            while (!validName)
            {
                name = Console.ReadLine();
                validName = Validation.IsValidName(name);
            }

            string password = Console.ReadLine();
            bool validPassword = Validation.IsValidPassword(password);
            while (!validPassword)
            {
                password = Console.ReadLine();
                validPassword = Validation.IsValidPassword(password);
            }

            double salary = double.Parse(Console.ReadLine());
            bool validBalance = Validation.IsValidBalance(salary);
            while (!validBalance)
            {
                salary = double.Parse(Console.ReadLine());
                validBalance = Validation.IsValidBalance(salary);
            }

            admin.editEmployee(id, name, password, salary);
        }
        public static bool adminOptions(Admin admin)
        {
            bool keep = true;
            printAdminMenu();
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    newEmployee(admin);
                    break;
                case 2:
                    admin.ListEmployees();
                    break;
                case 3:
                    searchForEmployee(admin);
                    break;
                case 4:
                    editEmployeeInfo(admin);
                    break;
                case 5:
                    keep = false;
                    break;
                default:
                    Console.WriteLine("InValid Option chose again");
                    break;

            }
            return keep;
        }


    }
}
