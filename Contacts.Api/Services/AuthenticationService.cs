using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Contacts.Api.Models;
using Contacts.Api.Repositories;
using Contacts.Api.Requests;

namespace Contacts.Api.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository autheniticationRepository;
        private readonly IConfiguration configuration;

        public AuthenticationService(IAuthenticationRepository autheniticationRepository, IConfiguration configuration)
        {
            this.autheniticationRepository = autheniticationRepository;
            this.configuration = configuration;
        }

        public async Task<User> Registration(UserRegistrationRequest request)
        {
            var user = await autheniticationRepository.FindUserByUserName(request.UserName);

            if (user == null)
            {
                request.Password = BCrypt.Net.BCrypt.HashPassword(request.Password);

                var registredUser = await autheniticationRepository.Registration(request);

                return registredUser;
            }

            throw new Exception("User already exists.");
        }

        public async Task<string> Login(UserLoginRequest request)
        {
            var user = await autheniticationRepository.FindUserByUserName(request.UserName);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
            {
                throw new Exception("Invalid user or password.");
            }

            var token  = CreateToken(user);

            return token;
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var JWTToken = new JwtSecurityTokenHandler().WriteToken(token);

            return JWTToken;
        }
    }
}

