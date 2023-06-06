using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.Open();
            app.LoginHelper.Login(new AccountData("admin", "secret"));
            app.GroupHelp.GoToGroupPage();
            app.GroupHelp.InitNewGroupCreation();
            GroupDate group = new GroupDate("aaa")
            {
                Header = "bbb",
                Footer = "ccc"
            };
            app.GroupHelp.FillGroupForm(group);
            app.GroupHelp.SubmitGroupCreation();
            app.GroupHelp.GoToGroupPage();
            app.LoginHelper.Logout();
        }
    }
}
