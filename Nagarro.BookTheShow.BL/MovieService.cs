using Nagarro.BookTheShow.Interfaces.Domain;
using Nagarro.BookTheShow.Interfaces.Repositories;
using Nagarro.BookTheShow.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookTheShow.BL
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public  MovieService(IMovieRepository userRepository)
        {
            _movieRepository = userRepository;
        }

        public void CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
        }

        public IEnumerable<Movie> GetAllMovie()
        {
            return _movieRepository.GetAllMovie();
        }

        public Movie GetMovie(int id)
        {
            return _movieRepository.GetMovie(id);
        }

        public void UpdateMovie(int id, Movie movie)
        {
            _movieRepository.UpdateMovie(id, movie);
        }
    }
}
