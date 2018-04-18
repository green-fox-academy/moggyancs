using System.Collections.Generic;

namespace MyReddit.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> UserPosts { get; set; }
    }
}
