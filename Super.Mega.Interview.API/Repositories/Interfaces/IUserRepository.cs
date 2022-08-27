using Super.Mega.Interview.Common.Model;

namespace Super.Mega.Interview.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(int id);

        Task<User> UpdateUserAsync(User user);

        Task DeleteUserAsync(User user);
    }
}
