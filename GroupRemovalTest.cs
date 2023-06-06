using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            navigator.Open();
            loginHelper.Login(new AccountData("admin", "secret"));
            groupHelp.GoToGroupPage();
            groupHelp.SelectGroup(1);
            groupHelp.RemoveGroup();
            groupHelp.GoToGroupPage();
            loginHelper.Logout();
        }
    }
}

