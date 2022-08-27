using Super.Mega.Interview.API.Repositories.Interfaces;
using Super.Mega.Interview.Common.Model;

namespace Super.Mega.Interview.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private const int MOQ_USERS_AMOUNT = 10;

        private readonly IDictionary<int, User> _users;

        public UserRepository()
        {
            _users = new Dictionary<int, User>();
            SetMoqUsers(_users, MOQ_USERS_AMOUNT);
        }

        public Task<User> GetUserAsync(int id)
        {
            return Task.FromResult(_users[id]);
        }

        public Task<User> UpdateUserAsync(User user)
        {
            _users[user.Id] = user;
            return Task.FromResult(user);
        }

        public Task DeleteUserAsync(User user)
        {
            _users.Remove(user.Id);
            return Task.CompletedTask;
        }

        private void SetMoqUsers(IDictionary<int, User> users, int moqUsersAmount)
        {
            for (int i = 1; i <= moqUsersAmount; i++)
            {
                users.Add(i, GetMoqUser(i));
            }
        }

        private User GetMoqUser(int Id)
        {
            return new User
            {
                Id = Id,
                Name = $"User {Id}",
                Email = $"someusername{Id}@mail.com"
            };
        }
    }
}
