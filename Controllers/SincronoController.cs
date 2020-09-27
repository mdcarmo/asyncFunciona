using System.Diagnostics;
using System.Threading.Tasks;
using ExAsyncApi.ExternalService;
using ExAsyncApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExAsyncApi.Controllers
{
    [ApiController]
    [Route("endpoint_sincrono")]
    public class SincronoController : ControllerBase
    {
        private readonly ISincronoService _sincronoService;

        public SincronoController(ISincronoService sincronoService)
        {
            _sincronoService = sincronoService;
        }

        [HttpGet("sincrono")]
        public IActionResult ExemploSincrono()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var albums = _sincronoService.GetAlbums();
            var comments = _sincronoService.GetComments();
            var photos = _sincronoService.GetPhotos();
            var posts = _sincronoService.GetPosts();
            var todos = _sincronoService.GetTodos();
            var users = _sincronoService.GetUsers();

            stopwatch.Stop();

            var modeloUnificado = new ModeloUnificado()
            {
                TempoExecucaoSeg = stopwatch.Elapsed.TotalSeconds,
                Albums = albums,
                Comments = comments,
                Photos = photos,
                Posts = posts,
                Users = users,
                Todos = todos
            };

            return Ok(modeloUnificado);
        }
    }
}