using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharp8.Features
{
    public class MyProjectContext : DbContext
    {

    }


    public interface IUserService : IAsyncDisposable
    {

    }


    public class UserService : IUserService
    {
        private readonly MyProjectContext _context;


        public void Dispose()
        {
            _context.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
