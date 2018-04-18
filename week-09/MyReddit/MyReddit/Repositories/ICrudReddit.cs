using MyReddit.Models;
using System.Collections.Generic;

namespace MyReddit.Repositories
{
    public interface ICrudReddit
    {
        List<Post> GetAllPosts();
        void CreatePost(Post post);
        void UpvotePost(int postID);
        void DownVotePost(int postID);
        void DeletePost(int postID);
    }
}
