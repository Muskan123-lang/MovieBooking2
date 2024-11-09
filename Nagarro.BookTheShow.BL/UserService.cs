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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public IEnumerable<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        public void UpdateUser(int id, User user)
        {
            _userRepository.UpdateUser(id, user);
        }

        public User GetUserByEmail(string email, string password)
        {
            return _userRepository.GetUserByEmail(email,password);
        }
    }
}
