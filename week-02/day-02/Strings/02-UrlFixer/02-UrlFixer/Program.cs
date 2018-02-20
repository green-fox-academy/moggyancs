using System;
using System.Text;

namespace _02_UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("bots", "odds");

            // replace a part & concatenation
            string url2 = url + "/";
            url2 = url2.Replace("https//", "https://");

            // Stringbuilder insert
            StringBuilder url3 = new StringBuilder();
            url3.Append(url);
            url3.Insert(url3.Length, "/");
            url3.Insert(5, ":");
                       
            Console.WriteLine("changed the last bit: \t\t\t" + url);
            Console.WriteLine("replace a part & concatenation: \t" + url2);
            Console.WriteLine("Stringbuilder insert: \t\t\t" + url3);
            Console.ReadLine();
        }
    }
}
