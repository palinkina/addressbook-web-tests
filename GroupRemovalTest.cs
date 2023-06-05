using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            Open();
            LoginHelper.Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupPage();
            Logout();
        }
    }
}

