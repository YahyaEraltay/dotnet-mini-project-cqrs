using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> Delete(User user)
        {
            var deletedUser = _context.Users.FirstOrDefaultAsync(x => x.Id == user.Id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> Detail(Guid id)
        {
            var user = await _context.Users
                                     .Include(x => x.Department)
                                     .FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        public async Task<List<User>> GetAll()
        {
            var users = await _context.Users
                                      .Include(x=>x.Department)
                                      .ToListAsync();
            return users;
        }

        public async Task<User> Update(User user)
        {
            var updatedUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == user.Id);
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return updatedUser;
        }
    }
}
