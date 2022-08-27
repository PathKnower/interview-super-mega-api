using Super.Mega.Interview.Common.Model;

namespace Super.Mega.Interview.Services.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser(int id);

        Task<User> UpdateUser(User user);

        Task<User> DeleteUser(User user);
    }
}
