using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{
   

    public class ContactRepository : IContactRepository
    {
        
        private List<Contact> _contacts = new List<Contact>();
        private int _nextId = 1;

        public ContactRepository()
        {
            AddContact(new Contact { Name = "Ian Tunbridge", Email = "itunbridge@hotmail.com", Phone = "801-634-1339", DateModified = DateTime.UtcNow });
            AddContact(new Contact { Name = "John Doe", Email = "john@doe.com", Phone = "801-555-5555", DateModified = DateTime.UtcNow });
            AddContact(new Contact { Name = "Sally Sue", Email = "sally@sue.com", Phone = "801-444-4444", DateModified = DateTime.UtcNow });
        }
        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public Contact GetContact(int id)
        {
            return _contacts.Find(c => c.Id == id);
        }

        public Contact AddContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("contact");
            }
            contact.Id = _nextId++;
            _contacts.Add(contact);
            return contact;
        }

        public bool RemoveContact(int id)
        {
            _contacts.RemoveAll(c => c.Id == id);
            return true;
        }

        public bool UpdateContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("contact");
            }
            int index = _contacts.FindIndex(c => c.Id == contact.Id);
            if (index == -1)
            {
                return false;
            }
            _contacts.RemoveAt(index);
            _contacts.Add(contact);
            return true;
        }
    }
}