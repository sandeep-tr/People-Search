using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Models;
using System.Collections.Generic;

/*
 Contains test cases to check the Person Model.
 */

namespace PeopleSearch.Tests.Features
{
    [TestClass]
    public class PersonModelTest
    {
        [TestMethod]
        public void Check_Person_Object()
        {
            var data = new Person();
            data.FirstName = "User";
            data.LastName = "Test";
            data.Interests = new List<PersonInterest>();
            data.Interests.Add(new PersonInterest() { Interest = "Football" });
            data.Interests.Add(new PersonInterest() { Interest = "Movies" });

            Assert.AreEqual("Test", data.LastName);
            Assert.AreEqual(2, data.Interests.Count);
        }
    }
}
