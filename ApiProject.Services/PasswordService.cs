using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiProject.Entities;
using Zxcvbn;

namespace ApiProject.Services
{
    public class PasswordService : IPasswordService
    {
        public int CheckStrongPass(string pass)
        {
            var result = Zxcvbn.Core.EvaluatePassword(pass);
            
            return result.Score;
        }
    }
}