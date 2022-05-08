namespace Challange.Dtos
{
    public record CreateMovieDto
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public int Rating { get; set; }
        public double BudgetUsd { get; set; }
    }
}
