using System.Configuration;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace BasicProject.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        protected BasePage(string url, IWebDriver driver)
        {
            _url = url;

            if (driver != null)
            {
                _driver = driver;
            }
            else
            {
                _driver = new ChromeDriver();
                _driver.Navigate().GoToUrl(Url);
            }

            PageFactory.InitElements(_driver, this);
        }

        protected Dictionary<string, BasePage> PageCollection
        {
            get
            {
                if (_pageCollection == null)
                {
                    _pageCollection = new Dictionary<string, BasePage>
                    {
                        {ConfigurationManager.AppSettings["LoginUrl"].ToString(), new LoginPage(_driver)},
                        {ConfigurationManager.AppSettings["HomeUrl"].ToString(), new HomePage(_driver)}
                    };
                }

                return _pageCollection;
            }
        }

        private Dictionary<string, BasePage> _pageCollection = null;

        protected string Url
        {
            get
            {
                return _url;
            }
        }

        private string _url;

        protected BasePage GetPage(string pageUrl = null)
        {
            if (pageUrl == null)
            {
                    pageUrl = _driver.Url;
            }

            return PageCollection[pageUrl];
        }
    }
}
