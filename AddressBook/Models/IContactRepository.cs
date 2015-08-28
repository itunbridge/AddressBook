using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();
        Contact GetContact(int id);
        Contact AddContact(Contact contact);
        bool RemoveContact(int id);
        bool UpdateContact(Contact contact);
    }
}
