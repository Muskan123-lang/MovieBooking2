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
    public class UserMovieBookService : IUserMovieBookService
    {
        private readonly IUserMovieBookRepository _userMovies;

        public UserMovieBookService(IUserMovieBookRepository userMovies)
        {
            _userMovies = userMovies;
        }

        public void CreateUserMovie(UserMovieBook movie)
        {
            _userMovies.CreateUserMovie(movie);
        }

        public void DeleteUserMovie(int id)
        {
            _userMovies.DeleteUserMovie(id);
        }

        public IEnumerable<UserMovieBook> GetAllUserMovie()
        {
           return _userMovies.GetAllUserMovie();
        }

        public UserMovieBook GetUserMovie(int id)
        {
            return _userMovies.GetUserMovie(id);
        }

        public void UpdateUserMovie(int id, UserMovieBook movie)
        {
            _userMovies.UpdateUserMovie(id, movie);
        }
    }
}
