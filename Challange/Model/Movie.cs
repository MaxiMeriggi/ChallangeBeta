namespace Challange.Model
{
    public record Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public int Rating { get; set; }
        public double BudgetUsd { get; set; }
    }
}
