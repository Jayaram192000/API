using Microsoft.EntityFrameworkCore;
using timer_2.Data;
using timer_2.Models;

namespace timer_2.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _db.tblUser.ToListAsync();
            if(users is null)
            {
                return null;
            }
            return users;
        }
        public async Task<User> GetByName(string name)
        {
            var users = await _db.tblUser.FirstOrDefaultAsync(u => u.fldname == name);
            return users;
        }

        public async Task<User> CreateUser(User user)
        {
            _db.tblUser.Add(user);
            _db.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            _db.tblUser.Update(user);
            _db.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUser(User user)
        {
            _db.tblUser.Remove(user);
            _db.SaveChangesAsync();
            return user;
        }
    }
}
