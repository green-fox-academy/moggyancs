using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Docks
    {
        private string name;
        private List<Pirate> Sailors = new List<Pirate>();

        public Docks(string name)
        {
            this.name = name; 
        }
        public void ReadyToBoard(Pirate pirate)
        {
            Sailors.Add(pirate);
        }
        public List<Pirate> GetSailors()
        {
            return Sailors;
        }
        public void WhoIsReady()
        {
            foreach (var sailor in Sailors)
            {
                Console.WriteLine(sailor.Name + " - " + (sailor.IsAwake() ? $"ready to serve in {name}" : $"passed out in {name}"));
            }
        }
       
    }
}
