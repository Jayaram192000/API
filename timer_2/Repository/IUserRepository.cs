using timer_2.Models;

namespace timer_2.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetByName(string name);

        Task<User> CreateUser(User user);

        Task<User> UpdateUser(User user);

        Task<User> DeleteUser(User user);

    }
}
