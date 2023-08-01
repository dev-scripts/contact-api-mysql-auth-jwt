using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contacts.Api.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public required string UserName { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Password { get; set; }
    }
}
