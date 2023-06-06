using OpenQA.Selenium;


namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL)
            : base(driver)
        {
            this.baseURL = baseURL;
        }
        public void Open()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void OpenContactPage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }
    }
}
