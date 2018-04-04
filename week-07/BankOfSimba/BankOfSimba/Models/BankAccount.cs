namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }

        public BankAccount(string name, string balance, string animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }

    }
}
