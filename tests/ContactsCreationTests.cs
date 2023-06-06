using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {
        [Test]
        public void ContactsCreationTest()
        {
            app.Navigator.Open();
            app.LoginHelper.Login(new AccountData("admin", "secret"));
            app.Contacter.AddNewContact();
            app.Contacter.NewContact(new ContactDate("Polina", "Skryabina"));
            app.LoginHelper.Logout();
        }
    }
}