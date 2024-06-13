using Automation_Part_Two.Pages;
using OpenQA.Selenium;


namespace Automation_Part_Two.StepDefinitions
{
    [Binding]
    public class LogoutStepDefinitions
    {
        private IWebDriver driver;
        LogoutObject logoutPage;

        public LogoutStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [When(@"Enter Username")]
        public void WhenEnterUsername()
        {
            logoutPage = new LogoutObject(driver);
            logoutPage.getUsername();
            
        }

        [When(@"Enter password")]
        public void WhenEnterPassword()
        {
            logoutPage.getUserPassword();
        }

        [Then(@"Verify that the home page tagline and logo")]
        public void ThenVerifyThatTheHomePageTaglineAndLogo()
        {
            logoutPage.taglineText();
        }

        [When(@"Click the login button")]
        public void WhenClickTheLoginButton()
        {
            logoutPage.getLoginButton();
        }

        [When(@"Click on the Logout Button")]
        public void WhenClickOnTheLogoutButton()
        {
            logoutPage.getLogOutButton();
        }


    }
}
