using EvoSpan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvoSpan.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<UserLogin> Login(string id, string password)
        {
            /// TODO:
            /// Check if the UserId and UserPassword are linked to the IdManagment.
            /// And also check if the UserId and UserPassword are correct.
            
        }
    }
}
