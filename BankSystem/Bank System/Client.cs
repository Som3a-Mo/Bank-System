
namespace Bank_System
{
    internal class Client: Person
    {
        public double Balance { get; set; }

        public bool setBalance(double balance)
        {
            bool isValid = Validation.IsValidBalance(balance);
            if (!isValid)
            {
                Console.WriteLine("The balnce is not valid");
            }else
            {
                this.Balance = balance;
            }
            return isValid;
        }

        public void deposit(double amount)
        {
            this.Balance += amount;
        }

        public void withdaw(double amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("un valid operation");
            }
        }

        public void transferTo(Client recipient, double amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                recipient.deposit(amount);
            }
            else
            {
                Console.WriteLine("un valid operation");
            }
        }

        public void checkBalance()
        {
            Console.WriteLine($"Your Balance is: ${this.Balance}");
        }
        public override string? ToString()
        {
            return base.ToString() + $", Balance: {this.Balance}";
        }
    }
}
