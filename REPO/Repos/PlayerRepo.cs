using Laliga.DBContext;
using Laliga.DTOs;
using Laliga.Models;
using Laliga.REPO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Laliga.REPO.Repos
{
    public class PlayerRepo : IPlayerRepo
    {
        private readonly AppDbContext _context;
        public PlayerRepo(AppDbContext context)
        {
            _context = context;
        }
        
        public void AddAllPlayer(AddAllPlayerDto addAllPlayerDto)
        {
            Player player = new Player
            {
                PlayerName = addAllPlayerDto.PlayerNameDto,
                laligaa = new Models.Laligaa
                {
                    LaligaWinner = addAllPlayerDto.laligaDto.LaligaWinnerDto,
                },
                team = new Team
                {
                    TeamName = addAllPlayerDto.teamDto.TeamNameDto,
                }

            };
            _context.Players.Add(player);
            _context.SaveChanges();
        }
        public AddAllPlayerDto GetPlayerById(int id)
        {
            var result = _context.Players.Include(x => x.laligaa).Include(x => x.team).FirstOrDefault(x => x.PlayerID == id);
            var addAllPlayerDto = new AddAllPlayerDto
            {
                PlayerNameDto = result.PlayerName,
                laligaDto = new LaligaDto
                {
                    LaligaWinnerDto = result.laligaa.LaligaWinner,
                },
                teamDto = new TeamDto
                {
                    TeamNameDto = result.team.TeamName
                }
            };
            return addAllPlayerDto;
        }
        public List<AddAllPlayerDto> GetAllPlayer()
        {
            var result = _context.Players.Include(x => x.laligaa).Include(x => x.team).Select(m => new AddAllPlayerDto
            {
                PlayerNameDto = m.PlayerName,
                laligaDto = new LaligaDto
                {
                    LaligaWinnerDto = m.laligaa.LaligaWinner,
                },
                teamDto = new TeamDto
                {
                    TeamNameDto = m.team.TeamName
                }

            }).ToList();
            return result;
        }
    }
}