using BasicProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BasicProject.Steps
{
    [Binding]
    public class LoginSteps : BaseSteps<LoginPage>
    {
        BasePage GettingPage;

        [Given(@"I navigate to login page")]
        public void GivenINavigateToLoginPage()
        {
            Page = new LoginPage();
        }

        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterUserNameAndPassword(string username, string password)
        {
            Page.EnterUsernameAndPassword(username, password);
        }

        [When(@"I submit logon form")]
        public void WhenISubmitLogonForm()
        {
            GettingPage = Page.Logon();
        }

        [Then(@"I get home page")]
        public void ThenIGetHomePage()
        {
            Assert.AreEqual(GettingPage.GetType(), typeof(HomePage));
        }
    }
}