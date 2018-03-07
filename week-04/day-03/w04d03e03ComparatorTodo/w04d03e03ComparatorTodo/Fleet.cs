using System;
using System.Collections.Generic;

namespace w04d03e03ComparatorTodo
{
    public class Fleet
    {
        public List<Thing> Things;

        public Fleet() 
        {
            Things = new List<Thing>(); 
        }

        public void Add(Thing thing) 
        {
            Things.Add(thing);
        }

        public List<Thing> GetList() 
        {
            return Things;
        }

    }
}