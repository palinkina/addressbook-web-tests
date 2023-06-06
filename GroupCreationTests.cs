using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            navigator.Open();
            loginHelper.Login(new AccountData("admin", "secret"));
            groupHelp.GoToGroupPage();
            groupHelp.InitNewGroupCreation();
            GroupDate group = new GroupDate("aaa")
            {
                Header = "bbb",
                Footer = "ccc"
            };
            groupHelp.FillGroupForm(group);
            groupHelp.SubmitGroupCreation();
            groupHelp.GoToGroupPage();
            loginHelper.Logout();
        }
    }
}
