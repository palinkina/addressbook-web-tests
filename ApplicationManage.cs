using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
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

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";

            loginHelper = new Login_outHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelp = new GroupHelper(driver);
            contacter = new ContactHelper(driver);
        }
    }
    
}
