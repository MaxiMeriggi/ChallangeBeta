using Challange.Dtos;
using Challange.Model;

namespace Challange.Extensions
{
    public static class MovieExtensions
    {
        public static MovieDto AsDto(this Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Name = movie.Name,
                Duration = movie.Duration,
                Rating = movie.Rating,
                BudgetUsd = movie.BudgetUsd
            };
        }
    }
}
