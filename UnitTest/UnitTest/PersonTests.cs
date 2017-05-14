using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTest
{
    class PersonTests
    {
        [Test]
        public void TestPersonConstructor()
        {
            Person person = new Person("Juan", "Perez", 25);
            Assert.AreEqual(25,person.Age);
            Assert.AreEqual("Juan Perez", person.FullName);
            Assert.AreEqual(100000, person.CashBalance);
        }
        [Test]
        public void TestPersonBuyACar()
        {
            Person person = new Person("Juan", "Perez", 25);
            Assert.True(person.BuyCar(1000));
        }
        [Test]
        public void TestPersonCantBuyACar()
        {
            Person person = new Person("Juan", "Perez", 25);
            Assert.False(person.BuyCar(-1000000));
        }
    }
}
