using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExAsyncApi.Models;
using Newtonsoft.Json;

namespace ExAsyncApi.ExternalService
{
    public class AssincronoService : IAssincronoService
    {
        private readonly HttpClient _httpClient;
        public AssincronoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

        }

        public async Task<IEnumerable<Album>> GetAlbumsAsync()
        {
            // var responseMessage = await _httpClient.GetAsync($"albums/?nocache={Guid.NewGuid()}");
            // var responseText = await responseMessage.Content.ReadAsStringAsync();
            // var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(responseText);
            // return albums;

            await Task.Delay(1000);

            return new List<Album>
            {
                new Album{

                }
            };
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync()
        {
            // var responseMessage = await _httpClient.GetAsync($"comments/?nocache={Guid.NewGuid()}");
            // var responseText = await responseMessage.Content.ReadAsStringAsync();
            // var comments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseText);
            // return comments;

            await Task.Delay(1000);

            return new List<Comment>
            {
                new Comment{

                }
            };
        }

        public async Task<IEnumerable<Photo>> GetPhotosAsync()
        {
            // var responseMessage = await _httpClient.GetAsync($"photos/?nocache={Guid.NewGuid()}");
            // var responseText = await responseMessage.Content.ReadAsStringAsync();
            // var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseText);
            // return photos;

            await Task.Delay(1000);

            return new List<Photo>
            {
                new Photo{

                }
            };
        }

        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            // var responseMessage = await _httpClient.GetAsync($"posts/?nocache={Guid.NewGuid()}");
            // var responseText = await responseMessage.Content.ReadAsStringAsync();
            // var posts = JsonConvert.DeserializeObject<IEnumerable<Post>>(responseText);
            // return posts;

            await Task.Delay(1000);

            return new List<Post>
            {
                new Post{

                }
            };
        }

        public async Task<IEnumerable<Todo>> GetTodosAsync()
        {
            // var responseMessage = await _httpClient.GetAsync($"todos/?nocache={Guid.NewGuid()}");
            // var responseText = await responseMessage.Content.ReadAsStringAsync();
            // var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(responseText);
            // return todos;

            await Task.Delay(1000);

            return new List<Todo>
            {
                new Todo{

                }
            };
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            // var responseMessage = await _httpClient.GetAsync($"users/?nocache={Guid.NewGuid()}");
            // var responseText = await responseMessage.Content.ReadAsStringAsync();
            // var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseText);
            // return users;

            await Task.Delay(1000);

            return new List<User>
            {
                new User{

                }
            };
        }
    }
}