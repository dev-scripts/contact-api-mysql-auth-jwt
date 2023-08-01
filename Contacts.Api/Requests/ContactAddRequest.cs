using System.ComponentModel.DataAnnotations;

namespace Contacts.Api.Requests
{
    public class ContactAddRequest
    {
        [Required]
        public required string FullName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required long Phone { get; set; }

        [Required]
        public required string Address { get; set; }
    }
}