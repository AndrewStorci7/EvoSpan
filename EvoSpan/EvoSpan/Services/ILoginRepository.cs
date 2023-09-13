using EvoSpan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvoSpan.Services
{
    public interface ILoginRepository
    {
        Task<UserLogin> Login(string id, string password);
    }
}
