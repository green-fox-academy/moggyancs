using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet(); 

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat Lunch"));

            fleet.GetList()[3].Complete();
            fleet.GetList()[2].Complete();

            Print(fleet);
        }

        public static void Print(Fleet fleet) 
        {
            string status;
            for (int i = 0; i < fleet.GetList().Count; i++)
            {
                if (fleet.GetList()[i].GetStatus())
                {
                    status = "+";
                }
                else
                {
                    status = " ";
                }
                Console.WriteLine(i + 1 + ". [" + status + "]" + fleet.GetList()[i].GetName());

            }
            Console.ReadLine();

        }


    }
}