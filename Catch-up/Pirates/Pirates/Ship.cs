using System;
using System.Collections.Generic;
using System.Text;


namespace Pirates
{
    class Ship
    {
        private string name;
        private Pirate captain;
        private List<Pirate> Crew = new List<Pirate>();

        private static Random rnd = new Random();
        int crewNr = rnd.Next(1, 6);

        public Ship(string name)
        {
            this.name = name;
        }
        
        public void AssignCaptain(Pirate captain)
        {
            this.captain = captain;
        }
        public void FillShip(Pirate captain)
        {
            this.captain = captain;
            for (int i = 0; i < crewNr; i++)
            {
                Crew.Add(new Pirate());
            }
        }

        public void AddCrew(Docks sailors)
        {
            foreach (var pirate in sailors.GetSailors())
            {
                if (pirate.IsAwake())
                {
                     Crew.Add(pirate);
                }
            }
        }

        public void AddCrewMember(Pirate sailor)
        {
            Crew.Add(sailor);
        }

        public void GetMyCrew()
        {
            Console.WriteLine($"This is the {name}, whose captain is the dreadful {captain.Name}, served by ");
            foreach (var member in Crew)
            {
            Console.WriteLine(member.Name + " - " + (member.IsAwake() ? "ready to serve" : "passed out"));
            }
        }

        public void ItIsMorning()
        {
            foreach (var pirate in Crew)
            {
                pirate.WakeUp();
            }
        }

        public bool Battle(Ship OtherShip)
        {
            int ourscore = 6;
            int theirscore = 5;
            if (ourscore - theirscore >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }


}
