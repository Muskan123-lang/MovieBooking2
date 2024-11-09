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
    public class MovieListingService : IMovieListingService
    {
        private readonly IMovieListingRepository _movieRepository;

        public MovieListingService(IMovieListingRepository userRepository)
        {
            _movieRepository = userRepository;
        }


        public void CreateMovieListing(MovieListing movieslot)
        {
            _movieRepository.CreateMovieListing(movieslot);
        }

        public void DeleteMovieListing(int id)
        {
            _movieRepository.DeleteMovieListing(id);
        }

        public IEnumerable<MovieListing> GetAllMovieListing()
        {
            return _movieRepository.GetAllMovieListing();
        }

        public MovieListing GetMovieListing(int id)
        {
           return _movieRepository.GetMovieListing(id);
        }

        public void UpdateMovieListing(int id, MovieListing movieslot)
        {
            _movieRepository.UpdateMovieListing(id, movieslot);
        }
    }
}
