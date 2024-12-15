namespace Laliga.DTOs
{
    public class LaligaDto
    {
        public string? LaligaWinnerDto { get; set; }
    }
    public class AddAllLaligaDto
    {
        public string? LaligaWinnerDto { get; set; }
        public List<PlayerDto>? playerDtos { get; set; }
    }
}