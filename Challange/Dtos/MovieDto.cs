using System.ComponentModel.DataAnnotations;

namespace Challange.Dtos
{
    public record MovieDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Duration { get; set; }
        public int Rating { get; set; }
        public double BudgetUsd { get; set; }
    }
}
