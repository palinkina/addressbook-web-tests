using OpenQA.Selenium;


namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    { 
        public ContactHelper(IWebDriver driver) : base(driver)
        {
        }
    public void AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public ContactHelper NewContact(ContactDate contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.XPath("//input[21]")).Click();
            return this;
        }

        public ContactHelper AddContact()
        {
            AddNewContact();
           NewContact(new ContactDate("Polina", "Skryabina"));
            return this;
        }
    }
}
