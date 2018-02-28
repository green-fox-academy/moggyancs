using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Entries DJ001 = new Entries("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04");
            Entries UT001 = new Entries("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            Entries TW001 = new Entries("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine("I borrowed this post from {0}, originally posted on {1}. \n {2} \n \n {3}", DJ001.authorName, DJ001.date, DJ001.title, DJ001.text);
            Console.ReadLine();
        }
    }
}
