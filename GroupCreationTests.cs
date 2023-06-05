using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            Open();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            InitNewGroupCreation();
            GroupDate group = new GroupDate("aaa")
            {
                Header = "bbb",
                Footer = "ccc"
            };
            FillGroupForm(group);
            SubmitGroupCreation();
            GoToGroupPage();
        }
    }
}
