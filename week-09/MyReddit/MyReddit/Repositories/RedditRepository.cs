using MyReddit.Entities;
using MyReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyReddit.Repositories
{
    public class RedditRepository : ICrudReddit
    {
        MyRedditContext context;

        public RedditRepository(MyRedditContext context)
        {
            this.context = context;
        }

        public List<Post> GetAllPosts()
        {
            return context.Posts.ToList();
        }

        public Post GetOnePost(int postID)
        {
            return context.Posts.FirstOrDefault(p => p.Id == postID);
        }

        public void CreatePost(Post post)
        {
            context.Add(post);
            post.Timestamp = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            context.SaveChanges();
        }

        public void UpvotePost(int postID)
        {
            GetOnePost(postID).Score++;
            context.SaveChanges();
        }

        public void DownVotePost(int postID)
        {
            GetOnePost(postID).Score--;
            context.SaveChanges();
        }

        public void DeletePost(int postID)
        {
            context.Remove(GetOnePost(postID));
            context.SaveChanges();
        }

        public void AddUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }
    }
}
