using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {
        [Test]
        public void ContactsCreationTest()
        {
            app.Contacter.AddContact();
            app.Auth.Logout();
        }
    }
}