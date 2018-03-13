using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Pirate
    {
        string name;
        int drunkness;
        bool awake;
        Random rnd = new Random();

        public string Name { get => name; set => name = value; }

        public Pirate(string name)
        {
            this.Name = name;
            this.drunkness = 0;
            this.awake = true;
        }

        public Pirate()
        {
            this.name = "one useless noname bastard";
            this.drunkness = 0;
            this.awake = true;
        }

        public void DrinkSomeRum()
        {
            Console.WriteLine();
            drunkness++;
        }

        public void DrinkSomeRum(int pint)
        {
            Console.WriteLine();
            drunkness += pint;
            if (drunkness >= 4)
            {
                awake = false;
            }
        }

        public void HowIsItGoingMate()
        {
            Console.WriteLine($"- How is it going, {name}?");
            if (drunkness <= 4)
            {
                Console.WriteLine($"- I just had {drunkness} rounds, mate. Pour me anudder!");
            }
            else
            {
                Console.WriteLine("- Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                awake = false;
            }
        }

        public bool IsAwake()
        {
            return awake;
        }

        public void Bawl(Pirate opponent)
        {
            Console.WriteLine($"{name} got in a fistfight with {opponent.name}.");
            int odds = rnd.Next(1, 3);
            if (odds == 1)
            {
                awake = false;
                Console.WriteLine($"The fistfight ended, {name} passed out." );
            }
            else if (odds == 2)
            {
                opponent.awake = false;
                Console.WriteLine($"The fistfight ended, {opponent.name} passed out.");
            }
            else
            {
                awake = false;
                opponent.awake = false;
                Console.WriteLine("The fistfight ended, both participants passed out");
            }
            Console.WriteLine();
        }

    }
}
