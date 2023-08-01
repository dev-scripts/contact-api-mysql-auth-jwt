using System;
using Contacts.Api.Models;
using Contacts.Api.Requests;

namespace Contacts.Api.Repositories
{
    public interface IAuthenticationRepository
    {
        public Task<User> Registration(UserRegistrationRequest request);
        public Task<User?> FindUserByUserName(string userName);
    }
}