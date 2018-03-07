using System;

namespace w04d03e03ComparatorTodo 
{
    public class Thing : IComparable<Thing>
    {
        private string Name;
        private bool Completed;

        public Thing(string name) 
        {
            this.Name = name;
        }

        public int CompareTo(Thing other)
        {
            if (Completed != other.Completed)
            {
                return Completed.CompareTo(other.Completed);
            }
            else
            {
                return Name.CompareTo(other.Name);
            }
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