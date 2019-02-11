using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement Register { get; set; }
    }
        {
        [FindsBy(How = How.Id, Using = "first name")]
        private IWebElement firstName { get; set }


    public void ClickOnRegister()
    {
        register.click();
    }
    public void EnterFirstName()
    {
          firstName.SendKeys("funmi")
        
    }

       }

        {
            

        }

}
