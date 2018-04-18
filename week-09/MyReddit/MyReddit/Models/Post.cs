namespace MyReddit.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public long Timestamp { get; set; }
        public int Score { get; set; }
        public User Owner { get; set; }
    }
}
