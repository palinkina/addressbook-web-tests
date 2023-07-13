using NUnit.Framework;



namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactDate newName = new ContactDate("Nova", "Poly");
            
            app.Contacter.Modify(newName);
        }
    }
}
