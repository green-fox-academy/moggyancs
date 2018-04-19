using Microsoft.AspNetCore.Mvc;
using MyReddit.Models;
using MyReddit.Repositories;
using System.Collections.Generic;

namespace MyReddit.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        ICrudReddit Reddit;
        public RESTController(ICrudReddit reddit)
        {
            Reddit = reddit;
        }

        [HttpGet("posts")]
        public IActionResult Posts()
        {
            var posts = Reddit.GetAllPosts();
            return new OkObjectResult(posts);
        }

        [HttpPost("posts")]
        public Post CreatePost([FromBody] PostDTO post, [FromHeader] string username)
        {
            int id = Reddit.CreatePost(post, username);
            return Reddit.GetOnePost(id);
        }

        [HttpPut("posts/{id}/upvote")]
        public IEnumerable<Post> UpvotePost([FromRoute] int id)
        {
            Reddit.UpvotePost(id);
            return Reddit.GetAllPosts();
        }

        [HttpPut("posts/{id}/downvote")]
        public IEnumerable<Post> DownvotePost([FromRoute] int id)
        {
            Reddit.DownVotePost(id);
            return Reddit.GetAllPosts();
        }

        [HttpDelete("posts/{id}")]
        public IEnumerable<Post> DeletePost([FromRoute] int id)
        {
            Reddit.DeletePost(id);
            return Reddit.GetAllPosts();
        }

        [HttpPost("users")]
        public IEnumerable<User> AddUser([FromBody] User user)
        {
            Reddit.AddUser(user);
            return Reddit.GetAllUsers();
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            var users = Reddit.GetAllUsers();
            return new OkObjectResult(users);
        }

        [HttpGet("users/{id}")]
        public IActionResult GetUser([FromRoute] int id)
        {
            var user = Reddit.GetOneUser(id);
            return new OkObjectResult(user);
        }
    }
}
