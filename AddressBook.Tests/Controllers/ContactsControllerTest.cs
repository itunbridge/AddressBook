using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook;
using AddressBook.Controllers;
using AddressBook.Models;

namespace AddressBook.Tests.Controllers
{
    [TestClass]
    public class ContactsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            // Act
            IEnumerable<Contact> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual("Ian Tunbridge", result.ElementAt(0).Name);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            // Act
            Contact result = controller.Get(1);

            // Assert
            Assert.AreEqual("Ian Tunbridge", result.Name);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            // Act
            controller.Post(new Contact { Name = "Test McTesterson", Email = "test@test.com", Phone = "(801) 333-3333", DateModified = DateTime.UtcNow });

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            // Act
            controller.Put(new Contact { Id = 1, Name = "Not Ian", Email = "test@test.com", Phone = "(801) 333-3333", DateModified = DateTime.UtcNow });

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            // Act
            controller.Delete(1);

            // Assert
        }
    }
}
