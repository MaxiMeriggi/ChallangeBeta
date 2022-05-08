using Challange.Dtos;
using Challange.Extensions;
using Challange.Model;
using Challange.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Challange.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IInMemMoviesRepositories repository;
        public MoviesController(IInMemMoviesRepositories repository)
        {
            this.repository = repository;
        }


        // GET /movies
        [HttpGet]
        public IEnumerable<MovieDto> GetMovies()
        {
            var movies = repository.GetMovies().Select(movie => movie.AsDto());
            return movies;
        }

        //GET /movies/id
        [HttpGet("{id}")]
        public ActionResult<MovieDto> GetMovie(Guid id)
        {
            var movie = repository.GetMovies(id);

            if (movie is null) return NotFound();

            return movie.AsDto();
        }

        //Post /movies
        [HttpPost]
        public ActionResult<MovieDto> CreateMovie(CreateMovieDto movieDto)
        {
            Movie movie = new()
            {
                Id = Guid.NewGuid(),
                Name = movieDto.Name,
                Duration = movieDto.Duration,
                Rating = movieDto.Rating,
                BudgetUsd = movieDto.BudgetUsd
            };

            repository.CreateMovie(movie);

            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie.AsDto());
        }

        //Put /movies/id
        [HttpPut("{id}")]
        public ActionResult UpdateMovie(Guid id, UpdateMovieDto movieDto)
        {
            var existingMovie = repository.GetMovies(id);

            if (existingMovie is null) return NotFound();

            Movie updatedMovie = existingMovie with
            {
                Name = movieDto.Name,
                Rating = movieDto.Rating,
                BudgetUsd = movieDto.BudgetUsd,
                Duration = movieDto.Duration
            };

            repository.UpdateMovie(updatedMovie);

            return NoContent();
        }

        //Delete /movies/id
        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(Guid id)
        {
            var movie = repository.GetMovies(id);

            if (movie is null) return NotFound();

            repository.DeleteMovie(id);

            return NoContent();
        }
    }
}
