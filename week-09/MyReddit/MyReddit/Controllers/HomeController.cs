using Microsoft.AspNetCore.Mvc;
using MyReddit.Models;
using MyReddit.Repositories;
using System.Collections.Generic;

namespace MyReddit.Controllers
{
    public class HomeController : Controller
    {
        ICrudReddit Reddit;

        public HomeController(ICrudReddit reddit)
        {
            Reddit = reddit;
        }

        [HttpGet("/posts")]
        public IActionResult Index()
        {
            var posts = Reddit.GetAllPosts();
            return new OkObjectResult(posts);
        }

        [HttpPost("/posts")]
        public IEnumerable<Post> CreatePost([FromBody] Post post)
        {
            Reddit.CreatePost(post);
            return Reddit.GetAllPosts();
        }

        [HttpPut("/posts/{id}/upvote")]
        public IEnumerable<Post> UpvotePost([FromRoute] int id)
        {
            Reddit.UpvotePost(id);
            return Reddit.GetAllPosts();
        }

        [HttpPut("/posts/{id}/downvote")]
        public IEnumerable<Post> DownvotePost([FromRoute] int id)
        {
            Reddit.DownVotePost(id);
            return Reddit.GetAllPosts();
        }

        [HttpDelete("/posts/{id}")]
        public IEnumerable<Post> DeletePost([FromRoute] int id)
        {
            Reddit.DeletePost(id);
            return Reddit.GetAllPosts();
        }

        [HttpPost("/users")]
        public IEnumerable<User> AddUser([FromBody] User user)
        {
            Reddit.AddUser(user);
            return Reddit.GetAllUsers();
        }

        [HttpGet("/users")]
        public IActionResult Users()
        {
            var users = Reddit.GetAllUsers();
            return new OkObjectResult(users);
        }

        [HttpGet("/users/{id}")]
        public IActionResult GetUser([FromRoute] int id)
        {
            var user = Reddit.GetOneUser(id);
            return new OkObjectResult(user);
        }
    }
}
