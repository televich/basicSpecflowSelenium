﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using TechTalk.SpecFlow; 

namespace BasicProject.Pages
{
    public class LoginPage : BasePage
    {
        protected readonly string url = ConfigurationManager.AppSettings["LoginUrl"];

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "LoginButton")]
        private IWebElement LoginButton { get; set; }

        public void EnterUsernameAndPasseord(string username, string passsword)
        {
            UserName.SendKeys(username);
            Password.SendKeys(passsword);
        }

        public BasePage Logon()
        {
            LoginButton.Click();
            return GetPage();
        }

    }
}
