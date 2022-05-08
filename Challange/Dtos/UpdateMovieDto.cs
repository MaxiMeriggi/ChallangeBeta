using System.ComponentModel.DataAnnotations;

namespace Challange.Dtos
{
    public class UpdateMovieDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Duration { get; set; }
        public int Rating { get; set; }
        public double BudgetUsd { get; set; }
    }
}
