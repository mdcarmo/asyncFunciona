
using System.Collections.Generic;
using System.Threading.Tasks;
using ExAsyncApi.Models;

namespace ExAsyncApi.ExternalService
{
    public interface IAssincronoService
    {
        Task<IEnumerable<Post>> GetPostsAsync();
        Task<IEnumerable<Comment>> GetCommentsAsync();
        Task<IEnumerable<Album>> GetAlbumsAsync();
        Task<IEnumerable<Photo>> GetPhotosAsync();
        Task<IEnumerable<Todo>> GetTodosAsync();
        Task<IEnumerable<User>> GetUsersAsync();
    }
}