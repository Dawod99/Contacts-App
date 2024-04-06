using contactsApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace contactsApp.Services
{
    public class ContactService
    {
        private List<Contact> contacts = new List<Contact>();

        public ContactService()
        {
            // Sample data for testing
            contacts.AddRange(new List<Contact>
            {
                new Contact { Id = 1, FirstName = "Ahmad", LastName = "Khaled", Email = "Ahmad@example.com", PhoneNumber = 0781424515 },
                new Contact { Id = 2, FirstName = "Bara", LastName = "Isaa", Email = "Bara@example.com", PhoneNumber = 0781424515 },
                new Contact { Id = 3, FirstName = "Calvin", LastName = "Klaine", Email = "Calvin@example.com", PhoneNumber = 0781424515 },
                new Contact { Id = 4, FirstName = "Dawod", LastName = "Abu-Yasin", Email = "Dawod@example.com", PhoneNumber = 0781987456 },
                new Contact { Id = 5, FirstName = "Fares", LastName = "Yosef", Email = "Fares@example.com", PhoneNumber = 0781424515 },
                new Contact { Id = 6, FirstName = "Gamal", LastName = "Ahmad", Email = "Gamal@example.com", PhoneNumber = 0781445555 },
            });
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return contacts;
        }

        public Contact GetContactById(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public void AddContact(Contact contact)
        {
            contact.Id = contacts.Count + 1;
            contacts.Add(contact);
        }

        public void UpdateContact(Contact contact)
        {
            var existingContact = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.PhoneNumber = contact.PhoneNumber;
            }
        }

        public void DeleteContact(int id)
        {
            var contactToDelete = contacts.FirstOrDefault(c => c.Id == id);
            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
            }
        }
    }
}

