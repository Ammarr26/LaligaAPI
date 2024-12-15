namespace Laliga.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        public List<Player>? players { get; set; }
    }
}