using System.ComponentModel.DataAnnotations;

namespace Contacts.Api.Requests
{
    public class ContactUpdateRequest
    {
        [Required]
        public required string FullName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public long Phone { get; set; }

        [Required]
        public required string Address { get; set; }
    }
}