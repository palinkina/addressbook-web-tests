using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupDate group = new GroupDate("aaa")
            {
                Header = "bbb",
                Footer = "ccc"
            };
            app.GroupHelp.Create(group);
            app.Auth.Logout();
        }
        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupDate group = new GroupDate("")
            {
                Header = "",
                Footer = ""
            };
            app.GroupHelp.Create(group);
            app.Auth.Logout();
        }
    }
}
