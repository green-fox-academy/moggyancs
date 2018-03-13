using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Ship
    {
        private string name;
        private Pirate captain;
        private List<Pirate> crew;

        public Ship(string name)
        {
            this.name = name;
        }

        public void FillShip(Pirate captain)
        {
            this.captain = captain;  

        }
        public void GetMyCrew()
        {
            Console.WriteLine($"This is the {name}, whose captain is the feared {captain}, served by ");
            foreach (var member in crew)
            {
            Console.WriteLine(member + " - " + (member.IsAwake() ? "ready to serve" : "passed out"));
            }
        }

    
    }


}
