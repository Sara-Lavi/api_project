using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiProject.Entities;

namespace ApiProject.Repositories
{
    public interface IUserRepository
    {
        public User Create(User user);

        public User Login(LoginUser userlogin); 

        public void Update(int id, User users);
    }
}
