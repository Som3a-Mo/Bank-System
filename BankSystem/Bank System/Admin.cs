
namespace Bank_System
{
    internal class Admin : Employee
    {

        public void addEmployee(Employee employee)
        {
            FilesHelper.saveEmployee(employee);
        }

        public Employee searchEmployee(int id)
        {
            Employee employee = FilesHelper.getEmployee(id);
            return employee;
        }

        public void ListEmployees()
        {
            FilesHelper.getEmployees();
        }

        public void editEmployee(int id, string name, string password, double salary)
        {
            Employee employee = searchEmployee(id);
            employee.setName(name);
            employee.setPassword(password);
            employee.setSalary(salary);
        }

    }
}
