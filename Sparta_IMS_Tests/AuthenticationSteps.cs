using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class AuthenticationSteps
    {
        [Given(@"I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            WebBrowser.Current.GoTo("https://localhost:44397/");

            WebBrowser.Current.Button(Find.ByClass("test")).Click();

            Assert.IsTrue(WebBrowser.Current.Link(Find.ByText("Click Me!")).Exists);
        }
        
        [Given(@"I have entered the valid details in all the fields")]
        public void GivenIHaveEnteredTheValidDetailsInAllTheFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press sign in")]
        public void WhenIPressSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on the appropriate page")]
        public void ThenIShouldBeOnTheAppropriatePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
