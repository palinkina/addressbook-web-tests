using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Text;


namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected Login_outHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelp;
        protected ContactHelper contacter;

        public void ApplicationManagers()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";


            loginHelper = new Login_outHelper(driver);
        navigator = new NavigationHelper(driver, baseURL);
        groupHelp = new GroupHelper(driver);
        contacter = new ContactHelper(driver);
        }
        public Login_outHelper LoginHelper
        {
            get
            {
                return loginHelper;
            }
        }
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }
        public GroupHelper GroupHelp
        {
            get
            {
                return groupHelp;
            }
        }
        public ContactHelper Contacter
        {
            get
            {
                return contacter;
            }
        }
    }
}
