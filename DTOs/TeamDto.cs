using System.ComponentModel.DataAnnotations;

namespace Laliga.DTOs
{
    public class TeamDto
    {
        [Required]
        public string? TeamNameDto { get; set; }
    }
}