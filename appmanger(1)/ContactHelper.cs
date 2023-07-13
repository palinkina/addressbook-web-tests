using OpenQA.Selenium;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    { 
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }
        public ContactHelper Modify(ContactDate newName)
        {
            manager.Navigator.OpenContactPage();
            EditContact();
            NewContact(newName);
            NewContact(new ContactDate("Nova", "Poly"));
            UpConatact();
            manager.Navigator.OpenContactPage();
            return this;
        }

        public ContactHelper Remove(int v)
        {
            manager.Navigator.OpenContactPage();
            SelectContact(v);
            RemoveContact();
            Confirm();
            manager.Navigator.OpenContactPage(); 
            return this;
        }

        private ContactHelper Confirm()
        {
            driver.SwitchTo().Alert().Accept();
            // Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("//tr[" + (index + 1) + "]//input")).Click();
            //driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
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
           NewContact(new ContactDate("Polina", "Skryabina"));
            return this;
        }
        public ContactHelper UpConatact()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        private ContactHelper EditContact()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
    }
}
