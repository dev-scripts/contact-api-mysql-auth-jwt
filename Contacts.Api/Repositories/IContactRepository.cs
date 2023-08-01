using Contacts.Api.Models;
using Contacts.Api.Requests;

namespace Contacts.Api.Repositories
{
    public interface IContactRepository
    {
        public Task<List<Contact>> GetAll();
        public Task<Contact> Store(ContactAddRequest request);
        public Task<Contact?> Update(Guid id, ContactUpdateRequest request);
        public Task<Contact?> Get(Guid id);
        public Task<bool> Delete(Guid id);
    }
}