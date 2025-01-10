

namespace Bank_System
{
    internal class Person
    {

        public int Id { get; set; }
        public string Name { get; protected set; }
        public string Password { get; protected set; }

        public bool setName(string name)
        {
            bool isValid = Validation.IsValidName(name);
            if (!isValid)
            {
                Console.WriteLine("The name Is not Valid Try Again.");
            }else
            {
                this.Name = name;
            }
            return isValid;
        }

        public bool setPassword(string password)
        {
            bool isValid = Validation.IsValidPassword(password);
            if (!isValid)
            {
                Console.WriteLine("The Password Is not Valid Try Again.");
            }
            else
            {
                this.Password = password;
            }
            return isValid;
        }

        public bool setId(int id)
        {
            bool ok = Validation.IsValidId(this, id);
            if (ok)
            {
                this.Id = id;
            }else
            {
                Console.WriteLine($"This Id: {id} is Already exist ");
            }

            return ok;
        }



        public virtual void Display()
        {
            Console.WriteLine(this.ToString());
        }

        public override string? ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}";
        }
    }
}
