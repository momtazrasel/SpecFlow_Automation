
using OpenQA.Selenium;
using Automation_Part_Two.Pages;

namespace Automation_Part_Two.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        LoginObject loginPage;

       public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the URL")]
        public void GivenEnterTheURL()
        {
           
            driver.Url = "https://stage.tombola.co.uk/my-account/loginsso#/login";
            Thread.Sleep(4000);
        }

        [When(@"Enter Invalid Username")]
        public void WhenEnterUsername()
        {
            loginPage = new LoginObject(driver);
            loginPage.getUsername();
            
        }

        [When(@"Enter Invalid password")]
        public void WhenEnterPassword()
        {
            loginPage.getUserPassword();
            

        }

        [When(@"Click on the login button")]
        public void WhenClickOnTheLoginButton()
        {
            loginPage.getLoginButton();
            
        }

        

        [When(@"Click on Logout Button")]
        public void WhenClickOnLogoutButton()
        {
            loginPage.getLogOutButton();
        }

        [Then(@"Verify that the home page tagline and logo and login form")]
        public void ThenVerifyThatTheHomePageTaglineAndLogoAndLoginForm()
        {
            loginPage.loginPageAssertions();


        }




    }
}