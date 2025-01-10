

namespace Bank_System
{
    internal interface DataSourceInterface
    {
        public void addClient(Client client);
        public void addEmployee(Employee employee);
        public void addAdmin(Admin admin);
        public List<Client> getAllClients();
        public List<Employee> getAllEmployees();
        public List<Admin> getAllAdmins();
        public void removeAllClients();
        public void removeAllEmployees();
        public void removeAllAdmins();
    }
}
