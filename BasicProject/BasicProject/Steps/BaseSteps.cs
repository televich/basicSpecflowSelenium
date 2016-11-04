using BasicProject.Pages;
using OpenQA.Selenium;
using System.Configuration;

namespace BasicProject.Steps
{
    public abstract class BaseSteps<T> where T : BasePage
    {
        
        ///<summary>
        ///Page object instance
        ///</summary>
        protected T Page { get; set; }

        //[BeforeScenario]
        //[AfterScenario]

        //[SetUp]
        //public virtual void SetUp()
        //{
        //    WebDriverContext = WebDriverContext.GetInstance();
        //    Page = Framework.Page.Create<T>(
        //         WebDriverContext.WebDriver,
        //          EnvironmentsConfiguration.CurrentEnvironmentBaseUrl,
        //          Url,
        //          PageElements);
        //}

        //[TearDown]
        //public virtual void TearDown()
        //{
        //    if (WebDriverContext.HasInstance)
        //    {
        //        var instance = WebDriverContext.GetInstance();
        //        instance.Dispose();
        //    }
        //}
    }
}