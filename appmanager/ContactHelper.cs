using OpenQA.Selenium;



namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    { 
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }
    public ContactHelper AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
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
           NewContact(new ContactDate("Poli", "Nova"));
            return this;
        }
    }
}
