using Super.Mega.Interview.Common.Model;

namespace Super.Mega.Interview.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int id);

        Task<User> UpdateUserAsync(User user);

        Task DeleteUserAsync(User user);
    }
}
