


namespace Bank_System
{
    internal class ClientManager
    {
        public static Client login(int id, string password)
        {
            Client client = FilesHelper.getClient(id);
            if (client == null)
            {
                Console.WriteLine("This Id is Uncorrect");
                return client;
            }
            if (password != client.Password)
            {
                Console.WriteLine("The password is Uncorrect");
                return null;
            }
            return client;
        }

        public static void updatePassword(string password)
        {

        }

        public static void printClientMenu()
        {
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Transfer Money");
            Console.WriteLine("5. logout");
        }

        public static bool clientOptions(Client client)
        {
            bool keep = true;
            printClientMenu();
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int moneyToDeposit = amountOfMoney();
                    client.deposit(moneyToDeposit);
                    break;
                case 2:
                    int moneyToWithdraw = amountOfMoney();
                    client.withdaw(moneyToWithdraw);
                    break;
                case 3:
                    client.checkBalance();
                    break;
                case 4:
                    Client recipient = getRecipient();
                    if (recipient != null)
                    {
                        int moneyToTransfer = amountOfMoney();
                        client.transferTo(recipient, moneyToTransfer);
                    }else
                    {
                        Console.WriteLine("This Client is not Exist");
                    }
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

        private static Client getRecipient()
        {
            Client recipient = null;
            Console.WriteLine("Enter recipient ID");
            int id = int.Parse(Console.ReadLine());
            recipient = FilesHelper.getClient(id);
            return recipient;
        }
        private static int amountOfMoney()
        {
            Console.Write("Enter amount of money: ");
            int money = int.Parse(Console.ReadLine());
            return money;
        }
    }
}
