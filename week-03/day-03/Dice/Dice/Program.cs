using System;

namespace Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6
        static Random RandomValue;
        static int[] Dices = new int[6]; // a method that creates an array of dices with 6 integers in it.

        public int[] Roll() //this adds the first 6 integers the array above, as the results of the roll
        {
            for (int i = 0; i < Dices.Length; i++) //end:array lenght
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
            return Dices; //returns the dices array with 6 random elements
        }

        public int[] GetCurrent() //looks at all elements in the array
        {
            return Dices;
        }

        public int GetCurrent(int i) //looks at one element of the array
        {
            return Dices[i];
        }

        public void Reroll() //reroll all the dices, aka reassign a value for the elements of the array
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
        }

        public void Reroll(int k) // reroll one dice
        {
            Dices[k] = new Random().Next(1, 7);
        }

        public static void Main(string[] args)
        {
            RandomValue = new Random(); // goes for random
            Dice myDice = new Dice(); //create dice class
            myDice.GetCurrent(); // 
            myDice.Roll();
            myDice.GetCurrent();
            myDice.GetCurrent(5);
            myDice.Reroll();
            myDice.GetCurrent();
            myDice.Reroll(4);
            myDice.GetCurrent();

              for (int i = 0; i < myDice.GetCurrent().Length; i++)
            {
                    if (myDice.GetCurrent(i) != 6)
                    {
                        Console.Write(myDice.GetCurrent(i) + ", ");
                        myDice.Reroll(i);
                    }

                    else
                    {
                        Console.WriteLine(myDice.GetCurrent(i));
                    }
            }
            Console.ReadLine();


        }
    }
}