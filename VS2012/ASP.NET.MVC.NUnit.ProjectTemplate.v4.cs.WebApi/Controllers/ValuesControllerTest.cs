using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using NUnit.Framework;
using $mvcprojectnamespace$;
using $mvcprojectnamespace$.Controllers;

namespace $safeprojectname$.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(2, Is.EqualTo(result.Count()));
            Assert.That("value1", Is.EqualTo(result.ElementAt(0)));
            Assert.That("value2", Is.EqualTo(result.ElementAt(1)));
        }

        [Test]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.That("value", Is.EqualTo(result));
        }

        [Test]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [Test]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Test]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
