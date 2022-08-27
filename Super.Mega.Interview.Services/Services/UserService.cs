using Super.Mega.Interview.Common.Model;
using Super.Mega.Interview.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super.Mega.Interview.Services.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
