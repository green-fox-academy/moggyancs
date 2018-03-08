using System;
using System.Collections.Generic;
using System.Text;

namespace w04d04e01Apple
{
    class Fruit
    {
        private string fruitname;

        public Fruit(string fruitname)
        {
            this.fruitname = fruitname;
        }

        public string GetFruit()
        {
            return "Hey, " + fruitname + "!";
        }
    }
}
