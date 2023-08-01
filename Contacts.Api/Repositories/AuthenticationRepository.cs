using Contacts.Api.Data;
using Contacts.Api.Models;
using Contacts.Api.Requests;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Api.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly ContactDbContext DbContext;

        public AuthenticationRepository(ContactDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public async Task<User> Registration(UserRegistrationRequest request)
        {
          
            var user = new User
            {
                Id = Guid.NewGuid(),
                UserName = request.UserName,
                Password = request.Password,
            };

            await DbContext.Users.AddAsync(user);
            await DbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User?> FindUserByUserName(string userName)
        {
            var user = await DbContext.Users
                         .Where(user => user.UserName == userName)
                         .FirstOrDefaultAsync();

            return user;
        }
    }
}

