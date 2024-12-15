using Laliga.DTOs;
using Laliga.REPO.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laliga.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaligaController : ControllerBase
    {
        private readonly ILaligaRepo _repo;
        public LaligaController(ILaligaRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddAllLaliga")]
        public IActionResult AddAllLaliga(AddAllLaligaDto addAllLaligaDto)
        {
            _repo.AddAllLaliga(addAllLaligaDto);
            return Ok();
        }

        [HttpGet("GetAllLaliga")]
        public IActionResult GetAllLaliga()
        {
            var result = _repo.GetAllLaliga();
            return Ok(result);
        }

        [HttpPut("UpdateLaliga")]
        public IActionResult UpdateLaliga(int id, AddAllLaligaDto addAllLaligaDto)
        {
            _repo.UpdateLaliga(id, addAllLaligaDto);
            return Ok();
        }
    }
}