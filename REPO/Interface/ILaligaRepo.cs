using Laliga.DTOs;

namespace Laliga.REPO.Interface
{
    public interface ILaligaRepo
    {
        public void AddAllLaliga(AddAllLaligaDto addAllLaligaDto);
        public List<AddAllLaligaDto> GetAllLaliga();
        public void UpdateLaliga(int id, AddAllLaligaDto addAllLaligaDto);
    }
}