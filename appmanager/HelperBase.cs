using OpenQA.Selenium;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}