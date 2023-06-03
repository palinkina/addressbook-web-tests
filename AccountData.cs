using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.FedCm;
using OpenQA.Selenium.Firefox;


namespace WebAddressbookTests
{
    class AccountData
    {
        private string username;
        private string password;
        

        public AccountData(string username, string password)
        
        { this.username = username;
          this.password = password;
        }
        public AccountData(string username)
        {
            this.username = username;
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
