using timer_2.DTO;
using timer_2.Models;
using timer_2.Repository;

namespace timer_2.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            if (users is null)
            {
                return null;
            }
            return users.Select(u => new UserDto
            {
                fldname = u.fldname,
                fldmail = u.fldmail
            });
        }

        public async Task<UserDto> GetByName(string name)
        {
            var user = await _userRepository.GetByName(name);
            return user != null ? new UserDto
            {
                fldname = user.fldname,
                fldmail = user.fldmail
            } : null;
        }

        public async Task<UserDto> CreateUser(UserDto user)
        {
            var createUser = new User
            {
                fldmail = user.fldmail,
                fldname = user.fldname,
                fldpassword = "Manual Password"
            };
            await _userRepository.CreateUser(createUser);
            return user;
        }
        public async Task<UserDto> UpdateUser(UserDto user)
        {
            var deleteUser = await _userRepository.GetByName(user.fldname);


            deleteUser.fldmail = user.fldmail;
               
            await _userRepository.UpdateUser(deleteUser);
            return user;
        }

        public async Task<UserDto> DeleteUser(string name)
        {
            var deleteUser = await _userRepository.GetByName(name);

            await _userRepository.DeleteUser(deleteUser);
            return deleteUser != null ? new UserDto
            {
                fldname = deleteUser.fldname,
                fldmail = deleteUser.fldmail
            } : null;
        }
    }
}
