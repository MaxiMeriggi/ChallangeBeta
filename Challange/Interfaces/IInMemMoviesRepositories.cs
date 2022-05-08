using Challange.Model;

namespace Challange.Repositories
{
    public interface IInMemMoviesRepositories
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovies(Guid id);
        void CreateMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(Guid id);
    }
}