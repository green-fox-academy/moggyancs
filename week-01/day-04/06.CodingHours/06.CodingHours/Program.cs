using System;

namespace _06.CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int dailyCodeTime = 6;
            int weekHours = (dailyCodeTime * 5);
            int semesterWeeks = 17;
            int avgWeekHours = 52;
            int semesterHours = (weekHours * semesterWeeks);
            var percent = Math.Round( ( (decimal)weekHours / (decimal)avgWeekHours) * 100, 2);

            
            Console.WriteLine("An average attendee codes {0} hours in a semester", semesterHours);
            Console.WriteLine("That is {0}% of the total working hours", percent);
            Console.ReadLine();
            {

            }
        }
    }
}
