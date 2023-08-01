using System;
using Contacts.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace Contacts.Api.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

