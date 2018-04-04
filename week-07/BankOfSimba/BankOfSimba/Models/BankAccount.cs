namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }
        public int ID { get; set; }
        private static int totalID;
        public bool Royalty { get; set; }

        public BankAccount(string name, string balance, string animalType, bool royalty)
        {
            ID = totalID;
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            totalID++;
            Royalty = royalty;
        }

    }
}
