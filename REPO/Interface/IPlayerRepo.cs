using Laliga.DTOs;

namespace Laliga.REPO.Interface
{
    public interface IPlayerRepo
    {
        public void AddAllPlayer(AddAllPlayerDto addAllPlayerDto);
        public AddAllPlayerDto GetPlayerById(int id);
        public List<AddAllPlayerDto> GetAllPlayer();
    }
}