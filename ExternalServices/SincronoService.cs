using System;
using System.Collections.Generic;
using System.Net.Http;
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
            var responseMessage = _httpClient.GetAsync($"albums/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(responseText);
            return albums;
        }

        public IEnumerable<Comment> GetComments()
        {
            var responseMessage = _httpClient.GetAsync($"comments/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var comments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseText);
            return comments;
        }

        public IEnumerable<Photo> GetPhotos()
        {
            var responseMessage = _httpClient.GetAsync($"photos/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseText);
            return photos;
        }

        public IEnumerable<Post> GetPosts()
        {
            var responseMessage = _httpClient.GetAsync($"posts/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var posts = JsonConvert.DeserializeObject<IEnumerable<Post>>(responseText);
            return posts;
        }

        public IEnumerable<Todo> GetTodos()
        {
            var responseMessage = _httpClient.GetAsync($"todos/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(responseText);
            return todos;
        }

        public IEnumerable<User> GetUsers()
        {
            var responseMessage = _httpClient.GetAsync($"users/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseText);
            return users;
        }
    }
}