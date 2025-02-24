using timer_2.DTO;
using timer_2.Models;

namespace timer_2.Service
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsers();
        Task<UserDto> GetByName(string name);

        Task<UserDto> CreateUser(UserDto user);

        Task<UserDto> UpdateUser(UserDto user);

        Task<UserDto> DeleteUser(string name);
    }
}
