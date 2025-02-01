using Microsoft.EntityFrameworkCore;
using bookshop.DbModels;
using Syncfusion.Blazor.Navigations.Internal;
using bookshop.Models;
namespace bookshop
{
    public class UserManagementService
    {
        public User UserLogedInSystem { get; set; } = new User();

        private readonly BookshopDbContext _context;

        public UserManagementService(BookshopDbContext context)
        {
            _context = context;
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User?> GetUserByLogin(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Login.Equals(login));
        }

        public async Task UpdateUser()
        {
          
        }
    }
}
