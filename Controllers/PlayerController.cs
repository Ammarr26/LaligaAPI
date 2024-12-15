using Laliga.DTOs;
using Laliga.REPO.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laliga.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepo _repo;
        public PlayerController(IPlayerRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddPlayer")]
        public IActionResult AddAllPlayer(AddAllPlayerDto addAllPlayerDto)
        {
            _repo.AddAllPlayer(addAllPlayerDto);
            return Ok();
        }

        [HttpGet("GetAllPlayer")]
        public IActionResult GetAllPlayer()
        {
            var result = _repo.GetAllPlayer();
            return Ok(result);
        }

        [HttpGet("GetPlayerById")]
        public IActionResult GetPlayerById(int id)
        {
            var result = _repo.GetPlayerById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}