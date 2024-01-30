using GameScrum.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameScrum.Api.Controllers
{
    [ApiController]
    [Route("/tabuleiro")]
    public class BoardController : Controller
    {
        private List<string> _players = new List<string>();

        [HttpPost]
        public async Task<IActionResult> InserirNome([FromBody] string nome)
        {
            if (_players.Count > 15)
            {
                return BadRequest("A sessão do jogo já está cheia.");
            }
            else
            {
                _players.Add(nome);
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Teste()
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


    }
}
