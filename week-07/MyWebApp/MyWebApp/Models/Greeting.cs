namespace MyWebApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        private static long TotalVisit = 0;

        public Greeting(string content)
        {
            Id = TotalVisit;
            Content = content;
            TotalVisit++;
        }

    }
}
