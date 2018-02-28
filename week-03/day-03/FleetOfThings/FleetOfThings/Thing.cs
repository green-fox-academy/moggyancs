using System;

namespace FleetOfThings
{
    public class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name) 
        {
            this.Name = name;
        }

        public void Complete() 
        {
            this.Completed = true;
        }

        public string GetName()
        {
            return Name;
        }

        public bool GetStatus()
        {
            return Completed;
        }
    }
}