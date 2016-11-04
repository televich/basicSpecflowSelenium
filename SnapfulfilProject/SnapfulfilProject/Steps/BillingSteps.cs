using BasicProject.Steps;
using System;
using TechTalk.SpecFlow;

namespace SnapfulfilProject.Steps
{
    [Binding]
    public class BillingSteps //: BaseSteps<LoginPage>
    {
        [Given(@"I login the web site")]
        public void GivenILoginTheWebSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open menu")]
        public void WhenIOpenMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click submenu '(.*)'")]
        public void WhenIClickSubmenu(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get billing page")]
        public void ThenIGetBillingPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
