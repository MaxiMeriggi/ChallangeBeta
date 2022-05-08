using Challange.Model;
using System.Linq;

namespace Challange.Repositories
{
    public class InMemMoviesRepositories : IInMemMoviesRepositories
    {
        private readonly List<Movie> movies = new()
        {
            new Movie { Id = Guid.NewGuid(), Name = "Endgame", Duration = "3h 20m", Rating = 94, BudgetUsd = 356000000 },
            new Movie { Id = Guid.NewGuid(), Name = "Infinity war", Duration = "2h 30m", Rating = 91, BudgetUsd = 316000000 }
        };

        public void CreateMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void DeleteMovie(Guid id)
        {
            var index = movies.FindIndex(existingMovies => existingMovies.Id == id);
            movies.RemoveAt(index);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        public Movie GetMovies(Guid id)
        {
            return movies.FirstOrDefault(movie => movie.Id == id);
        }

        public void UpdateMovie(Movie movie)
        {
            var index = movies.FindIndex(existingMovies => existingMovies.Id == movie.Id);
            movies[index] = movie;
        }
    }
}
