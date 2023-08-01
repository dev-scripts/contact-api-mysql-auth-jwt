using Contacts.Api.Models;
using Contacts.Api.Repositories;
using Contacts.Api.Requests;

namespace Contacts.Api.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task<List<Contact>> GetAll()
        {
            var contacts = await contactRepository.GetAll();

            return contacts;
        }

        public async Task<Contact> Store(ContactAddRequest request)
        {
            var contact = await contactRepository.Store(request);

            return contact;
        }

        public async Task<Contact?> Update(Guid id, ContactUpdateRequest request)
        {
            var contact = await contactRepository.Update(id, request);

            return contact;
        }

        public async Task<Contact?> Get(Guid id)
        {
            var contact = await contactRepository.Get(id);

            return contact;
        }

        public async Task<bool> Delete(Guid id)
        {
            var isDeleted = await contactRepository.Delete(id);

            return isDeleted;
        }
    }
}

