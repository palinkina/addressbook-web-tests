using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;

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

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";

            loginHelper = new Login_outHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelp = new GroupHelper(this);
            contacter = new ContactHelper(this);
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
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
        public Login_outHelper Auth
        {
            get
            {
                return loginHelper;
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

        public object ContactHelp { get; internal set; }
    }
}
