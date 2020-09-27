using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using ExAsyncApi.Models;
using Newtonsoft.Json;

namespace ExAsyncApi.ExternalService
{
    public class SincronoService : ISincronoService
    {
        private readonly HttpClient _httpClient;
        public SincronoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

        }
        public IEnumerable<Album> GetAlbums()
        {
            // var responseMessage = _httpClient.GetAsync($"albums/?nocache={Guid.NewGuid()}").Result;
            // var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            // var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(responseText);
            // return albums;

            Thread.Sleep(1000);

            return new List<Album>
            {
                new Album{

                }
            };
        }

        public IEnumerable<Comment> GetComments()
        {
            // var responseMessage = _httpClient.GetAsync($"comments/?nocache={Guid.NewGuid()}").Result;
            // var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            // var comments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseText);
            // return comments;

            Thread.Sleep(1000);

            return new List<Comment>
            {
                new Comment{

                }
            };
        }

        public IEnumerable<Photo> GetPhotos()
        {
            // var responseMessage = _httpClient.GetAsync($"photos/?nocache={Guid.NewGuid()}").Result;
            // var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            // var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseText);
            // return photos;

            Thread.Sleep(1000);

            return new List<Photo>
            {
                new Photo{

                }
            };
        }

        public IEnumerable<Post> GetPosts()
        {
            // var responseMessage = _httpClient.GetAsync($"posts/?nocache={Guid.NewGuid()}").Result;
            // var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            // var posts = JsonConvert.DeserializeObject<IEnumerable<Post>>(responseText);
            // return posts;

            Thread.Sleep(1000);

            return new List<Post>
            {
                new Post{

                }
            };
        }

        public IEnumerable<Todo> GetTodos()
        {
            // var responseMessage = _httpClient.GetAsync($"todos/?nocache={Guid.NewGuid()}").Result;
            // var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            // var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(responseText);
            // return todos;

            Thread.Sleep(1000);

            return new List<Todo>
            {
                new Todo{

                }
            };
        }

        public IEnumerable<User> GetUsers()
        {
            // var responseMessage = _httpClient.GetAsync($"users/?nocache={Guid.NewGuid()}").Result;
            // var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            // var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseText);
            // return users;

            Thread.Sleep(1000);

            return new List<User>
            {
                new User{

                }
            };
        }
    }
}