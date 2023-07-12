using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
           //driver.Navigate().GoToUrl("http://localhost/addressbook");
           driver.Navigate().GoToUrl(baseURL + "/addressbook/group.php");
        }
        public void OpenContactPage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }
        public void GoToGroupPage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook");
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
