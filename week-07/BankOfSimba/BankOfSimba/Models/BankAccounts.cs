using System.Collections.Generic;

namespace BankOfSimba.Models
{
    public class BankAccounts
    {
        List<BankAccount> Accounts = new List<BankAccount>()
        {
            new BankAccount("Simba", "2000", "East African Lion", true),
            new BankAccount("Nala", "5637.4", "East African Lion", true),
            new BankAccount("Timon", "2", "Meerkat", false),
            new BankAccount("Pumbaa", "20", "Common Warthog", false),
            new BankAccount("Scar", "500", "East African Lion", true),
            new BankAccount("Zazu", "1200.43", "Tanzanian Red-billed Hornbill", false),
            new BankAccount("Rafiki", "5463", "Mandrill", false),
            new BankAccount("Shenzi", "45254", "Spotted Hyena", false),
            new BankAccount("Banzai", "24525", "Spotted Hyena", false),
            new BankAccount("Ed", "4525", "Spotted Hyena", false)

        };

        public List<BankAccount> BankOfPrideLand()
        {
            return Accounts;
        }
    }
}
