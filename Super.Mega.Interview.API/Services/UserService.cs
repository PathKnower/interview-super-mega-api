using Super.Mega.Interview.Common.Model;
using Super.Mega.Interview.API.Services.Interfaces;
using Super.Mega.Interview.API.Repositories.Interfaces;

namespace Super.Mega.Interview.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        // Complete methods below

        public Task<User> GetUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
