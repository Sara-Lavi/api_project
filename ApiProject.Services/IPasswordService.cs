using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services
{
    public interface IPasswordService
    {
        public int CheckStrongPass(string pass);
    }
}
