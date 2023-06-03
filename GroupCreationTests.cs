using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests 
{
    [TestFixture]
    public class GroupCreationTests 
    {
        private IWebDriver driver; 
        private StringBuilder verificationErrors; 
        private string baseURL;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            verificationErrors = new StringBuilder();
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

        [Test]
        public void GroupCreationTest()
        {
            Open();
            Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            InitNewGroupCreation();
            GroupDate group = new GroupDate("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
        }

        private void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        private void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void FillGroupForm(GroupDate group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        private void InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        private void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[3]")).Click();
        }
      
        private void Open()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
    }
}
