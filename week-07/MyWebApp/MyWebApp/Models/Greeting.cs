namespace MyWebApp.Models
{
    public class Greeting
    {

        public Greeting(long id, string content)
        {
            Id = id;
            Content = content;
        }

        public long Id { get; set; }
        public string Content { get; set; }
    }
}
