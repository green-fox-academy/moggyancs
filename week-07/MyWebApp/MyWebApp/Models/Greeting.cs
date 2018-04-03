namespace MyWebApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        private string content;
        public string Content
        {
            get
            {
                return content;
            }
            private set
            {
                if (value == null)
                {
                    this.content = "Newbie";
                }
                else
                {
                    this.content = value;
                }

            }
        }
        private static long TotalVisit = 0;

        public Greeting(string content)
        {
            Id = TotalVisit;
            Content = content;
            TotalVisit++;
        }

    }
}
