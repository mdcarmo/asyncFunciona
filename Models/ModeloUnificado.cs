using System.Collections.Generic;

namespace ExAsyncApi.Models
{
    public class ModeloUnificado
    {
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
        public IEnumerable<User> Users { get; set; }
        public double TempoExecucaoSeg { get; set; }
    }
}