
using System.Security.Principal;

namespace Bank_System
{
    internal class Screens
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome to Som3a Bank's Online System!\n");
        }

        private static void loginOptions()
        {
            Console.WriteLine("1. Client Login");
            Console.WriteLine("2. Employee Login");
            Console.WriteLine("3. Admin Login");
            Console.WriteLine("4. Exit");
        }

        private static int loginAs()
        {
            loginOptions();
            int option = int.Parse(Console.ReadLine());
            while (option > 4 || option < 1)
            {
                option = int.Parse(Console.ReadLine());
            }
            return option;
        }


        private static void clientAction(Client client)
        {
            while (true)
            {
                bool keep = ClientManager.clientOptions(client);
                if (!keep) break;
            }
        }
        private static void employeeAction(Employee employee)
        {
            while (true)
            {
                bool keep = EmployeeManager.employeeOptions(employee);
                if (!keep) break;
            }
        }

        private static void adminAction(Admin admin)
        {
            while (true)
            {
                bool keep = AdminManager.adminOptions(admin);
                if (!keep) break;
            }
        }
        private static void loginScreen(int c)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            switch (c)
            {
                case 1:
                    Client client = ClientManager.login(id, password);
                    if (client is not null)
                    {
                        clientAction(client);
                        logout();
                    }
                    else
                    {
                        Console.WriteLine("The Passoword or Id is Wrong.");
                    }
                    break;
                case 2:
                    Employee employee = EmployeeManager.login(id, password);
                    if (employee is not null)
                    {
                        employeeAction(employee);
                        logout();

                    }
                    else
                    {
                        Console.WriteLine("The Passoword or Id is Wrong.");
                    }
                    break;
                case 3:
                    Admin admin = AdminManager.login(id, password);
                    if (admin is not null)
                    {
                        adminAction(admin);
                        logout();

                    }
                    else
                    {
                        Console.WriteLine("The Passoword or Id is Wrong.");
                    }
                    break;
            }
        }

        private static void logout()
        {
            Console.WriteLine("You have successfully logged out.");
        }

        public static void run()
        {
            welcome();
            while (true)
            {
                int rule = loginAs();
                if (rule == 4)
                {
                    Console.WriteLine("Thank you for visit our Bank see you soon ;)");
                    return;
                }
                loginScreen(rule);
            }
        }
    }
}
