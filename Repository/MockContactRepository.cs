using ContactManagementApi.Models;

namespace ContactManagementApi.Repository
{
    public class MockContactRepository
    {
        private List<Contact> _contacts = new List<Contact>();
        private int _currentId = 1;

        public List<Contact> GetContacts() => _contacts;
        public Contact GetContact(int id) => _contacts.FirstOrDefault(c => c.Id == id);
        public Contact AddContact(Contact contact)
        {
            contact.Id = _currentId++;
            _contacts.Add(contact);
            return contact;
        }
        public Contact UpdateContact(Contact contact)
        {
            var existing = _contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existing != null)
            {
                existing.FirstName = contact.FirstName;
                existing.LastName = contact.LastName;
                existing.Email = contact.Email;
            }
            return existing;
        }
        public bool DeleteContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _contacts.Remove(contact);
                return true;
            }
            return false;
        }
    }
}
}
