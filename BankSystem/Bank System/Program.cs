

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            employee.setId(1);
            Admin admin = new Admin();
            admin.addEmployee(employee);
            employee.setId(1);
            FilesHelper.clearAllEmployees();
        }
    }
}