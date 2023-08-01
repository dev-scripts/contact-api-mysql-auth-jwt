using System;
using Contacts.Api.Models;
using Contacts.Api.Requests;

namespace Contacts.Api.Services
{
    public interface IAuthenticationService
    {
        public Task<User> Registration(UserRegistrationRequest request);
        public Task<string> Login(UserLoginRequest request);
    }
}