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
    public class MovieSlotService : IMovieSlotService
    {
        private readonly IMovieSlotRepository _movieslotRepository;

        public MovieSlotService(IMovieSlotRepository movieslotRepository)
        {
            _movieslotRepository = movieslotRepository;
        }
        public void CreateMovieSlot(MovieSlot movieslot)
        {
            _movieslotRepository.CreateMovieSlot(movieslot);
        }

        public void DeleteMovieSlot(int id)
        {
            _movieslotRepository.DeleteMovieSlot(id);
        }

        public IEnumerable<MovieSlot> GetAllMovieSlot()
        {
            return _movieslotRepository.GetAllMovieSlot();
        }

        public MovieSlot GetMovieSlot(int id)
        {
            return _movieslotRepository.GetMovieSlot(id);
        }

        public void UpdateMovieSlot(int id, MovieSlot movieslot)
        {
            _movieslotRepository.UpdateMovieSlot(id, movieslot);
        }
    }
}
