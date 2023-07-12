using OpenQA.Selenium;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class HelperBase
    {
        
        protected IWebDriver driver;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}