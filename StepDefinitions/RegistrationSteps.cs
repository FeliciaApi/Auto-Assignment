using System;
using TechTalk.SpecFlow;

namespace Project.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter lastname")]
        public void WhenIEnterLastname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter email")]
        public void WhenIEnterEmail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on signUp")]
        public void WhenIClickOnSignUp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
