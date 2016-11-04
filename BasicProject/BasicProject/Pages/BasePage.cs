using System.Configuration;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace BasicProject.Pages
{
    public abstract class BasePage
    {
        protected BasePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            PageFactory.InitElements(driver, this);
        }

        protected Dictionary<string, BasePage> PageCollection
        {
            get
            {
                if(_pageCollection == null)
                {
                    _pageCollection = new Dictionary<string, BasePage>
                    {
                        {ConfigurationManager.AppSettings["LoginUrl"].ToString(), new LoginPage()},
                        {ConfigurationManager.AppSettings["HomeUrl"].ToString(), new HomePage()}
                    };
                }
                
                return _pageCollection;
            }
        }

        private Dictionary<string, BasePage> _pageCollection = null;

        public string Url
        {
            get 
            {
                return _url;
            }
        }

        protected string _url = null;

        protected BasePage GetPage(string pageUrl = null)
        {
            if (pageUrl == null)
            {
                pageUrl = ConfigurationManager.AppSettings["HomeUrl"];
            }
            return PageCollection[pageUrl];
        }

        private IWebDriver driver;
    }
}
