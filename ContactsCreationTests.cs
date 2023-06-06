using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {
        [Test]
        public void ContactsCreationTest()
        {
            navigator.Open();
            loginHelper.Login(new AccountData("admin", "secret"));
            contacter.AddNewContact();
            contacter.NewContact(new ContactDate("Polina", "Skryabina"));
            loginHelper.Logout();
        }
    }
}