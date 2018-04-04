using System.Collections.Generic;

namespace BankOfSimba.Models
{
    public class BankAccounts
    {
        List<BankAccount> Accounts = new List<BankAccount>()
        {
            new BankAccount("Simba", "2000", "East African Lion"),
            new BankAccount("Nala", "5637.4", "East African Lion"),
            new BankAccount("Timon", "2", "Meerkat"),
            new BankAccount("Pumbaa", "20", "Common Warthog"),
            new BankAccount("Scar", "500", "East African Lion"),
            new BankAccount("Zazu", "1200.43", "Tanzanian Red-billed Hornbill"),
            new BankAccount("Rafiki", "5463", "Mandrill"),
            new BankAccount("Shenzi", "45254", "Spotted Hyena"),
            new BankAccount("Banzai", "24525", "Spotted Hyena"),
            new BankAccount("Ed", "4525", "Spotted Hyena")

        };

        public List<BankAccount> BankOfPrideLand()
        {
            return Accounts;
        }
    }
}
