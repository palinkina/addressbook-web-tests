using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.Open();
            app.LoginHelper.Login(new AccountData("admin", "secret"));
            app.GroupHelp.GoToGroupPage();
            app.GroupHelp.SelectGroup(1);
            app.GroupHelp.RemoveGroup();
            app.GroupHelp.GoToGroupPage();
            app.LoginHelper.Logout();
        }
    }
}

