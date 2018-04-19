using Microsoft.EntityFrameworkCore;
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
            context.Users.Load();
            return context.Posts.ToList();
        }

        public Post GetOnePost(int postID)
        {
            return context.Posts.FirstOrDefault(p => p.Id == postID);
        }

        public int CreatePost(PostDTO post, string username)
        {
            Post newPost = new Post()
            {
                Timestamp = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds(),
                Title = post.Title,
                Url = post.Url,
                Owner = context.Users.FirstOrDefault(u => u.Name == username)
            };
            context.Add(newPost);
            context.SaveChanges();
            return newPost.Id;
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

        public List<User> GetAllUsers()
        {
            context.Posts.Load();
            return context.Users.ToList();
        }

        public User GetOneUser(int userID)
        {
            context.Posts.Load();
            return context.Users.FirstOrDefault(u => u.Id == userID);
        }

        public void DeleteUser(int userID)
        {
            context.Users.Remove(GetOneUser(userID));
        }
    }
}
