using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contacts.Api.Models
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; }

        [Column(TypeName = "integer(11)")]
        public long Phone { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Address { get; set; }
    }
}

