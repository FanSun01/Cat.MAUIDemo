using Cat.MauiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Cat.MauiDemo.Services
{
    public class PoetryService : IPoetryService
    {
        public const string DbFileName = "poetrydb.sqlite3";

        public static readonly string PoetryDbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DbFileName);

        private SQLiteAsyncConnection _connection;

        public SQLiteAsyncConnection Connection => _connection ??= new SQLiteAsyncConnection(PoetryDbPath);

        public async Task AddAsync(Poetry poetry)
        {
            await Connection.InsertAsync(poetry);
        }

        public async Task<IEnumerable<Poetry>> GetPoetryListAsync()
        {
            return await Connection.Table<Poetry>().ToListAsync();
        }

        public async Task InitializeAsync()
        {
            await Connection.CreateTableAsync<Poetry>();
        }

    }
}
