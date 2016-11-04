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
            Page.EnterUsernameAndPasseord(username, password);
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


/* correct instanse
  public class LoginSteps : WebDriverTestsBase<LoginPage>
  {
        [Given(@"I navigate to login page")]
        public void GivenINavigateToLoginPage()
        {
            //this.
        }

        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterUserNameAndPassword(string username, string password)
        {
            this.Page.EnterUsernameAndPasseord(username, password);
        }

        [When(@"I submit logon form")]
        public void WhenISubmitLogonForm()
        {
            this.Page.Logon();
        }

        [Then(@"I get home page")]
        public void ThenIGetHomePage()
        {
            // compare
        }
    }
 */



/*
[Binding]
public class LoginSteps //: WebDriverTestsBase<LoginPage>
{
    private IWebDriver driver = null;

    [Given(@"I navigate to login page")]
    public void GivenINavigateToLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://html5test.snapweb3.synlog.co.uk/Account/Login");
    }

    [When(@"I enter (.*) and (.*)")]
    public void WhenIEnterUserNameAndPassword(string username, string password)
    {
        driver.FindElement(By.Id("UserName")).SendKeys(username);
        driver.FindElement(By.Id("Password")).SendKeys(password);
        //this.Page.EnterUsernameAndPasseord(username, password);
    }

    [When(@"I submit logon form")]
    public void WhenISubmitLogonForm()
    {
        driver.FindElement(By.Id("LoginButton")).Click();
        //this.Page.Logon();
    }

    [Then(@"I get home page")]
    public void ThenIGetHomePage()
    {
        driver.Close();
        // compare
    }
}
*/