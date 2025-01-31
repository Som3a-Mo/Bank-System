


namespace Bank_System
{
    internal class EmployeeManager
    {
        public static Employee login(int id, string password)
        {
            Employee employee = FilesHelper.getEmployee(id);
            if (employee == null)
            {
                Console.WriteLine("This Id is Uncorrect");
                return employee;
            }
            if (password != employee.Password)
            {
                Console.WriteLine("The password is Uncorrect");
                return null;
            }
            return employee;
        }
        private static void printEmployeeMenu()
        {
            Console.WriteLine("1. Add a new client");
            Console.WriteLine("2. List all clients");
            Console.WriteLine("3. Search for a client");
            Console.WriteLine("4. Edit client information");
            Console.WriteLine("5. Logout");
        }

        private static void newClient(Employee employee)
        {
            Client client = new Client();
            int id = FilesHelper.clientIdGenerator();
            client.setId(id);
            Console.Write("Enter Client Name: ");
            string name = Console.ReadLine();
            bool validName = client.setName(name);
            while (!validName)
            {
                name = Console.ReadLine();
                validName = client.setName(name);
            }

            Console.Write("Enter Client Password: ");
            string password = Console.ReadLine();
            bool validPassword = client.setPassword(password);

            while (!validPassword)
            {
                password = Console.ReadLine();
                validPassword = client.setPassword(password);
            }

            Console.Write("Enter Client Balance: ");
            double balance = double.Parse(Console.ReadLine());
            bool validBalance = client.setBalance(balance);
            while (!validBalance)
            {
                balance = double.Parse(Console.ReadLine());
                validBalance = client.setBalance(balance);
            }
            Console.WriteLine($"The Client Id is: {id}");
            employee.addClient(client);
        }

        private static void searchForClient(Employee employee)
        {
            Console.Write("Enter client Id: ");
            int id = int.Parse(Console.ReadLine());
            Client client = FilesHelper.getClient(id);
            if (client == null)
            {
                Console.WriteLine("This Client is not exist");
                return;
            }
            Console.WriteLine($"The client with id: {id}, his name is: {client.Name}," +
                $" his Balance: {client.Balance}");
        }

        private static void editClientInfo(Employee employee)
        {
            Console.WriteLine("Enter client id: ");
            int id = int.Parse(Console.ReadLine());
            Client client = FilesHelper.getClient(id);
            if (client == null)
            {
                Console.WriteLine("This Client is not exist");
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

            double balance = double.Parse(Console.ReadLine());
            bool validBalance = Validation.IsValidBalance(balance);
            while (!validBalance)
            {
                balance = double.Parse(Console.ReadLine());
                validBalance = Validation.IsValidBalance(balance);
            }

            employee.editClient(id, name, password, balance);
        }

        public static bool employeeOptions(Employee employee)
        {
            bool keep = true;
            printEmployeeMenu();
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    newClient(employee);
                    break;
                case 2:
                    employee.ListClients();
                    break;
                case 3:
                    searchForClient(employee);
                    break;
                case 4:
                    editClientInfo(employee);
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
