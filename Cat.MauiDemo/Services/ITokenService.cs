using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat.MauiDemo.Services
{
    public interface ITokenService
    {
        Task<string> GetTokenAsync();
    }
}
