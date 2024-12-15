using Laliga.DBContext;
using Laliga.DTOs;
using Laliga.Models;
using Laliga.REPO.Interface;
using System;

namespace Laliga.REPO.Repos
{
    public class LaligaRepo : ILaligaRepo
    {
        private readonly AppDbContext _context;
        public LaligaRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddAllLaliga(AddAllLaligaDto addAllLaligaDto)
        {
            Laligaa laligaa = new Laligaa
            {
                LaligaWinner = addAllLaligaDto.LaligaWinnerDto,
                players = addAllLaligaDto.playerDtos.Select(player => new Player
                {
                    PlayerName = player.PlayerNameDto,
                    team = new Team
                    {
                        TeamName = player.teamDto.TeamNameDto,
                    }
                }).ToList(),
            };
            _context.Laligas.Add(laligaa);
            _context.SaveChanges();
        }

        public List<AddAllLaligaDto> GetAllLaliga()
        {
            var result = _context.Laligas.Select(x => new AddAllLaligaDto
            {
                LaligaWinnerDto = x.LaligaWinner,
                playerDtos = x.players.Select(player => new PlayerDto
                {
                    PlayerNameDto = player.PlayerName,
                    teamDto = new TeamDto
                    {
                        TeamNameDto = player.team.TeamName
                    },
                }).ToList(),
            }).ToList();
            return result;
        }
        
        public void UpdateLaliga(int id, AddAllLaligaDto addAllLaligaDto)
        {
            var result = _context.Laligas.FirstOrDefault(x => x.LaligaID == id);
            if (result != null)
            {
                result.LaligaWinner = addAllLaligaDto.LaligaWinnerDto;
                result.players = addAllLaligaDto.playerDtos.Select(x => new Player
                {
                    PlayerName = x.PlayerNameDto,
                    team = new Team
                    {
                        TeamName = x.teamDto.TeamNameDto,
                    }
                }).ToList();
            }
            _context.Laligas.Update(result);
            _context.SaveChanges();
        }
    }
}