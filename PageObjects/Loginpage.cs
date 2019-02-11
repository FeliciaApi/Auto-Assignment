using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.PageObjects
{
    public class Loginpage

    {
        //driver.FindElement(By.LinkText( "Login")
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement loginID;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        [FindsBy(How = How.ClassName, Using = "le- input")]
        private IWebElement passwordElement;


        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin;

        public Loginpage()
        {
            pageFactory.IntElement(driver, this);
    }

            public void ClickSignin()
        {
            signin.Click();
        }

        public void Typepassword()
        {
            passwordElement.SendKeys("mypasswordissecured");
            
        }
        
        public void TypeEmail()
        
        {
             emailElement.SendKeys("funmi@test.com");

        }

        public void ClickLogin()
        {
            loginID.Click();
        }
    }
}
