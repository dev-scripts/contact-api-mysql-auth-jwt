using System.ComponentModel.DataAnnotations;

namespace Contacts.Api.Requests
{
    public class UserRegistrationRequest
    {
        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}