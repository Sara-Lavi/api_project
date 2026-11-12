using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiProject.Entities;
using ApiProject.Repositories;

namespace ApiProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;


        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public User NewUser(User user)
        {
            return _userRepository.Create(user);
        }


        public User Login(LoginUser userlogin)
        {
            User user = _userRepository.Login(userlogin);
            if (user != null && user.Pass == userlogin.Pass)
            {
                return user;
            }
            return null;
        }


        public void Update(int id, User users)
        {
            _userRepository.Update(id, users);
        }
    }
}
