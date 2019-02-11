using Project.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Project.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        Loginpage loginpage;

        public LoginSteps()
        {
            Loginpage loginpage;
            loginpage = new Loginpage();

        }
        
        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
            loginpage.ClickLogin();  
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            loginpage.TypeEmail(); 
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            loginpage.Typepassword();     
    }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
           loginpage.ClickSignin();
        }
        
        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
