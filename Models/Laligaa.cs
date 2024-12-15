using System.ComponentModel.DataAnnotations;

namespace Laliga.Models
{
    public class Laligaa
    {
        [Key]
        public int LaligaID { get; set; }
        public string? LaligaWinner { get; set; }
        public List<Player>? players { get; set; }
    }
}