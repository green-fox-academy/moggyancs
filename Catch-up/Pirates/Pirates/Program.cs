using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship jamaica = new Ship("Jamaica");
            Pirate morgan = new Pirate("Captain Henry Morgan");

            jamaica.FillShip(morgan);
            jamaica.GetMyCrew();
            Console.WriteLine();

            Pirate hook = new Pirate("Captain James Hook");
            Pirate smee = new Pirate("Mr. Smee");
            Pirate john = new Pirate("John Smith");
            Pirate starkey = new Pirate("Gentleman Starkey");
            Pirate jukes = new Pirate("Bill Jukes");


            Ship roger = new Ship("The Jolly Roger");
            roger.AssignCaptain(hook);
            Docks tunis = new Docks("Tunis");
            tunis.ReadyToBoard(starkey);
            tunis.ReadyToBoard(john);
            tunis.ReadyToBoard(smee);
            john.DrinkSomeRum(6);
            Console.WriteLine();

            tunis.WhoIsReady();
            roger.AddCrew(tunis);
            roger.GetMyCrew();
            Console.WriteLine();
            starkey.Bawl(jukes);

            roger.AddCrewMember(jukes);
            roger.AddCrewMember(john);
            roger.GetMyCrew();

            hook.DrinkSomeRum(2);
            starkey.DrinkSomeRum(6);
            starkey.HowIsItGoingMate();
            hook.HowIsItGoingMate();

            Console.ReadLine();
        }
    }
}
