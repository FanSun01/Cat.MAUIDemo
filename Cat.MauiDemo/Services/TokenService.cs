using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat.MauiDemo.Services
{
    public class TokenService : ITokenService
    {
        public async Task<string> GetTokenAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://v2.jinrishici.com/token");
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }



    }
}
