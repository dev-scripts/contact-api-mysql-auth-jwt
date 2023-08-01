using Contacts.Api.Data;
using Contacts.Api.Models;
using Contacts.Api.Requests;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Api.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext DbContext;

        public ContactRepository(ContactDbContext contactDbContex)
        {
            this.DbContext = contactDbContex;
        }

        public async Task<List<Contact>> GetAll()
        {
            var contacts = await DbContext.Contacts.ToListAsync();

            return contacts;
        }

        public async Task<Contact> Store(ContactAddRequest request)
        {
            var contact = new Contact
            {
                Id = Guid.NewGuid(),
                FullName = request.FullName,
                Phone = request.Phone,
                Email = request.Email,
                Address = request.Address
            };

            await DbContext.Contacts.AddAsync(contact);
            await DbContext.SaveChangesAsync();

            return contact;
        }

        public async Task<Contact?> Update(Guid id, ContactUpdateRequest request)
        {
            var contact = await DbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                contact.FullName = request.FullName;
                contact.Phone = request.Phone;
                contact.Email = request.Email;
                contact.Address = request.Address;

                await DbContext.SaveChangesAsync();

                return contact;
            }

            return null;
        }

        public async Task<Contact?> Get(Guid id)
        {
            var contact = await DbContext.Contacts.FindAsync(id);

            return contact;
        }

        public async Task<bool> Delete(Guid id)
        {
            var contact = await DbContext.Contacts.FindAsync(id);
            if (contact != null)
            {
                DbContext.Remove(contact);
                await DbContext.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
