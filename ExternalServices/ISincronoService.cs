
using System.Collections.Generic;
using ExAsyncApi.Models;

namespace ExAsyncApi.ExternalService
{
    public interface ISincronoService
    {
        IEnumerable<Post> GetPosts();
        IEnumerable<Comment> GetComments();
        IEnumerable<Album> GetAlbums();
        IEnumerable<Photo> GetPhotos();
        IEnumerable<Todo> GetTodos();
        IEnumerable<User> GetUsers();
    }
}