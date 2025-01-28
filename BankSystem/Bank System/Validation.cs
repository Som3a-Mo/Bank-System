
using System.Text.RegularExpressions;

namespace Bank_System
{
    internal class Validation
    {
        private const string NamePattern = "^[a-zA-Z]{6,19}$";
        private const string PasswordPattern = "^[a-zA-Z0-9]{8,20}&";
        private const double Minimumbalance = 1500;
        private const double MinimumSalary = 5000;
        static public bool IsValidName(string name)
        {
            return Regex.IsMatch(name, NamePattern);
        }

        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, PasswordPattern);
        }

        static public bool IsValidSalary(double salary) {
            return salary >= MinimumSalary;
        }

        static public bool IsValidBalance(double balance)
        {
            return balance >= Minimumbalance;
        }

        
    }
}
