using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Text;
using System.Security.Policy;

namespace WebAddressbookTests
{
    public class TestBase
    {

        protected Login_outHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelp;
        protected ContactHelper contacter;

        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();

        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }  
    }
}
     

