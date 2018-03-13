using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate john = new Pirate("John Smith");
            Pirate hook = new Pirate("Captain James Hook");
            Pirate beard = new Pirate("BlackBeard");
            Pirate roberts = new Pirate("Bartholomew Roberts");
            Pirate morgan = new Pirate("Captain Henry Morgan");
            Pirate bonny = new Pirate("Anne Bonny");
            Pirate read = new Pirate("Mary Read");
            Pirate sparrow = new Pirate("Captain Jack Sparrow");
            Pirate smee = new Pirate("Mr. Smee");

            Ship pearl = new Ship("The Black Pearl");
            Ship roger = new Ship("The Jolly Roger");
            Ship jamaica = new Ship("Jamaica");

            jamaica.FillShip(morgan);
        }
    }
}
