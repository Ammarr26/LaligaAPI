namespace Laliga.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string? PlayerName { get; set; }
        public Laligaa? laligaa { get; set; }
        public Team? team { get; set; }
    }
}