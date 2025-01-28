
using System.Text.Json;

namespace Bank_System
{
    internal class FileManager : DataSourceInterface
    {
        public void addAdmin(Admin admin)
        {
            string file = "Admins.txt";
            List<Admin> admins = Parser.parseToObject<Admin>(File.ReadAllText(file));
            admins.Add(admin);
            string res = Parser.parseToJson<Admin>(admins);
            File.WriteAllText(file, res);
        }

        public void addClient(Client client)
        {
            string file = "Clients.txt";
            List<Client> clients = Parser.parseToObject<Client>(File.ReadAllText("Clients.txt"));
            clients.Add(client);
            string res = Parser.parseToJson<Client>(clients);
            File.WriteAllText(file, res);
        }

        public void addEmployee(Employee employee)
        {
            string file = "Employees.txt";
            List<Employee> employees = Parser.parseToObject<Employee>(File.ReadAllText(file));
            employees.Add(employee);
            string res = Parser.parseToJson<Employee>(employees);
            File.WriteAllText(file, res);
        }

        public List<Admin> getAllAdmins()
        {
            string file = "Admins.txt";
            string jsonText = File.ReadAllText(file);
            List<Admin> Admins = Parser.parseToObject<Admin>(jsonText);
            return Admins;
        }

        public List<Client> getAllClients()
        {
            string file = "Clients.txt";
            List<Client> clients = Parser.parseToObject<Client>(File.ReadAllText("Clients.txt"));
            return clients;
        }

        public List<Employee> getAllEmployees()
        {
            string file = "Employees.txt";
            List<Employee> employees = Parser.parseToObject<Employee>(File.ReadAllText(file));
            return employees;
        }

        public void removeAllAdmins()
        {
            string file = "Admins.txt";
            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Write))
            {
                fs.SetLength(0);
            }
        }

        public void removeAllClients()
        {
            string file = "Clients.txt";
            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Write))
            {
                fs.SetLength(0);
            }
        }

        public void removeAllEmployees()
        {
            string file = "Employees.txt";
            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Write))
            {
                fs.SetLength(0);
            }
        }
    }
}
