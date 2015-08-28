using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AddressBook.Controllers
{
    public class ContactsController : ApiController
    {
        static readonly IContactRepository repository = new ContactRepository();

        // GET api/contacts
        public IEnumerable<Contact> Get()
        {
            return repository.GetAllContacts();
        }

        // GET api/contacts/5
        public Contact Get(int id)
        {
            return repository.GetContact(id);
        }

        // POST api/contacts
        public Contact Post([FromBody]Contact contact)
        {
            return repository.AddContact(contact);
        }

        // PUT api/contacts/5
        public bool Put([FromBody]Contact contact)
        {
            return repository.UpdateContact(contact);
        }

        // DELETE api/contacts/5
        public bool Delete(int id)
        {
            return repository.RemoveContact(id);
        }
    }
}
