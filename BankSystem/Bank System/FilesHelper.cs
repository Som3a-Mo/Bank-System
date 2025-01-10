

namespace Bank_System
{
    internal class FilesHelper
    {
        private static readonly FileManager fileManager = new FileManager();

        public static void saveClient(Client client)
        {
            fileManager.addClient(client);
        }
        public static void saveEmployee(Employee employee)
        {
            fileManager.addEmployee(employee);
        }

        public static void getClients()
        {
            List<Client> clients = fileManager.getAllClients();
            foreach (Client client in clients)
            {
                Console.WriteLine($"Id: {client.Id}, Name: {client.Name}, " +
                    $"Password: {client.Password}, Balance: ${client.Balance}");
            }
        }
        public static void getEmployees()
        {
            List<Employee> employees = fileManager.getAllEmployees();
            foreach (Employee em in employees)
            {
                Console.WriteLine($"Id: {em.Id}, Name: {em.Name}, " +
                    $"Password: {em.Password}, Balance: ${em.Salary}");
            }
        }

        public static Client getClient(int id)
        {
            List<Client> clients = fileManager.getAllClients();
            Client client = clients.Where(client => client.Id == id).FirstOrDefault();
            return client;
        }

        public static Employee getEmployee(int id)
        {
            List<Employee> employees = fileManager.getAllEmployees();
            Employee employee = employees.Where(employee => employee.Id == id).FirstOrDefault();
            return employee;
        }

        public static void clearAllClients()
        {
            fileManager.removeAllClients();
        }
        public static void clearAllEmployees()
        {
            fileManager.removeAllEmployees();
        }
    }
}
