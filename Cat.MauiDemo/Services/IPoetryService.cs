using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cat.MauiDemo.Models;

namespace Cat.MauiDemo.Services
{
    public interface IPoetryService
    {
        Task InitializeAsync();
        Task AddAsync(Poetry poetry);
        Task<IEnumerable<Poetry>> GetPoetryListAsync();

    }
}
