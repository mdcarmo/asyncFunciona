using System.Diagnostics;
using System.Threading.Tasks;
using ExAsyncApi.ExternalService;
using ExAsyncApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExAsyncApi.Controllers
{
    [ApiController]
    [Route("endpoint_assincrono")]
    public class AssincronoController : ControllerBase
    {
        private readonly IAssincronoService _assincronoService;

        public AssincronoController(IAssincronoService assincronoService)
        {
            _assincronoService = assincronoService;
        }

        [HttpGet("assincrono1")]
        public async Task<IActionResult> ExemploAssincrono1()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var albums = await _assincronoService.GetAlbumsAsync();
            var comments = await _assincronoService.GetCommentsAsync();
            var photos = await _assincronoService.GetPhotosAsync();
            var posts = await _assincronoService.GetPostsAsync();
            var todos = await _assincronoService.GetTodosAsync();
            var users = await _assincronoService.GetUsersAsync();

            stopwatch.Stop();

            var modeloUnificado = new ModeloUnificado()
            {
                Albums = albums,
                Comments = comments,
                Photos = photos,
                Posts = posts,
                Users = users,
                Todos = todos,
                TempoExecucaoSeg = stopwatch.Elapsed.TotalSeconds,
            };

            return Ok(modeloUnificado);
        }

        [HttpGet("assincrono2")]
        public async Task<IActionResult> ExemploAssincrono2()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var albums = _assincronoService.GetAlbumsAsync();
            var comments = _assincronoService.GetCommentsAsync();
            var photos = _assincronoService.GetPhotosAsync();
            var posts = _assincronoService.GetPostsAsync();
            var todos = _assincronoService.GetTodosAsync();
            var users = _assincronoService.GetUsersAsync();

            var modeloUnificado = new ModeloUnificado()
            {
                TempoExecucaoSeg = 0,
                Albums = await albums,
                Comments = await comments,
                Photos = await photos,
                Posts = await posts,
                Users = await users,
                Todos = await todos
            };

            stopwatch.Stop();
            modeloUnificado.TempoExecucaoSeg = stopwatch.Elapsed.TotalSeconds;

            return Ok(modeloUnificado);
        }
    }
}