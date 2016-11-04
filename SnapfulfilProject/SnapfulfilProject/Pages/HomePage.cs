using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver = null) : base(ConfigurationManager.AppSettings["HomeUrl"], driver)
        {
        }
    }
}
