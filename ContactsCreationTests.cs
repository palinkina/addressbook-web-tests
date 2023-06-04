﻿using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {
        [Test]
        public void ContactsCreationTest()
        {
            Open();
            Login(new AccountData("admin", "secret"));
            AddNewContact();
            NewContact(new ContactDate("Polina", "Skryabina"));
            Logout();
        }
    }
}