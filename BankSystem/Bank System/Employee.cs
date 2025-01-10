

namespace Bank_System
{
    internal class Employee : Person
    {

        public bool setSalary(double salary)
        {
            bool isValid = Validation.IsValidSalary(salary);
            if (!isValid)
            {
                Console.WriteLine("The salary is not valid");
            }
            else
            {
                this.Salary = salary;
            }
            return isValid;
        }
        public double Salary { get; set; }

        public void addClient(Client client)
        {
            FilesHelper.saveClient(client);
        }

        public Client searchClient(int id)
        {
            Client client = FilesHelper.getClient(id);
            return client;
        }

        public void ListClients()
        {
            FilesHelper.getClients();
        }

        public void editClient(int id, string name, string password, double balance){
            Client client = searchClient(id);
            client.setName(name);
            client.setPassword(password);
            client.setBalance(balance);
        }

        public override string? ToString()
        {
            return base.ToString() + $", Salary: {this.Salary}";
        }
    }
}
