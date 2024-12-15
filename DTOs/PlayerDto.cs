namespace Laliga.DTOs
{
    public class PlayerDto
    {
        public string? PlayerNameDto { get; set; }
        public TeamDto? teamDto { get; set; }
    }
    public class AddAllPlayerDto
    {
        public string? PlayerNameDto { get; set; }
        public LaligaDto? laligaDto { get; set; }
        public TeamDto? teamDto { get; set; }
    }
}