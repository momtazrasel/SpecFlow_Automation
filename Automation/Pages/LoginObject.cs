using NUnit.Framework;
using OpenQA.Selenium;


namespace AutomationSpecflow.Pages
{
    public class LoginObject
    {
        private IWebDriver driver;

        public LoginObject(IWebDriver driver)
        {
            this.driver = driver;
        }


        //Locators
        By userName = By.XPath("//input[@name='LoginCredential']");
        By password = By.XPath("(//input[@name='Password'])[1]");
        By allCookies = By.XPath("(//button[@id='onetrust-accept-btn-handler'])[1]");
        By loginButton = By.XPath("(//button[normalize-space()='log in'])[1]");
        By crossIcon = By.XPath("(//span[@class='cross icon icon-cross'])[1]");
        By tagline = By.XPath("(//div[@class='tagline'])[1]");
        By logo = By.XPath("(//div[@class='logo iac'])[1]");
        By logOutButton = By.XPath("(//a[normalize-space()='logout'])[1]");
        By loginPageLogo = By.XPath("(//div[@class='col d-none d-lg-block bg-tombola-teal p-0 image-col'])[1]");
        By loginH3Header = By.XPath("(//h3[normalize-space()='Login to'])[1]");
        By tombolaImg = By.XPath("(//img[@id='tombola'])[1]");
        By errotMessage = By.XPath("(//li[@class='feedback-entry invalid-feedback-entry'])[1]");
        By usernameField = By.XPath("(//div[@class='form-group LoginCredential'])[1]");
        By passwordField = By.XPath("(//div[@class='form-group Password'])[1]");


        public void loginPageAssertions()
        {
           
            
            //Logo assertion
            bool isDisplayed = driver.FindElement(loginPageLogo).Displayed;
            Assert.IsTrue(isDisplayed, "The Logo is not displayed.");
            Thread.Sleep(1000);

            bool isDisplayedImg = driver.FindElement(tombolaImg).Displayed;
            Assert.IsTrue(isDisplayedImg, "The Img is not displayed.");
            Thread.Sleep(1000);

            string loginHeaderText = driver.FindElement(loginH3Header).Text;
            Assert.AreEqual("Login to", loginHeaderText, $"Expected text to be 'Login to' but was '{loginHeaderText}'");
            Thread.Sleep(1000);

            bool errotMessageText = driver.FindElement(errotMessage).Displayed;
            Assert.IsTrue(errotMessageText, "The Error message is not displayed.");
            Thread.Sleep(1000);

            bool userName = driver.FindElement(usernameField).Displayed;
            Assert.IsTrue(userName, "The username field is not displayed.");
            Thread.Sleep(1000);

            bool password = driver.FindElement(passwordField).Displayed;
            Assert.IsTrue(password, "The password is not displayed.");
            Thread.Sleep(1000);

            bool LoginButton = driver.FindElement(loginButton).Displayed;
            Assert.IsTrue(LoginButton, "The login button is not displayed.");
            Thread.Sleep(1000);




        }

        public void getUsername()
        {
               
         
            Thread.Sleep(5000);
            driver.FindElement(allCookies).Click();
            Thread.Sleep(2000);
            driver.FindElement(userName).Click();
            Thread.Sleep(1000);
            driver.FindElement(userName).SendKeys("Techtest");
        }

        public void getUserPassword()
        {
            Thread.Sleep(1000);
            driver.FindElement(password).Click();
            Thread.Sleep(1000);
            driver.FindElement(password).SendKeys("TechTest1");
            Thread.Sleep(1000);
        }

        public void getLoginButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(loginButton).Click();
            Thread.Sleep(3000);
        }
        public void getLogOutButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(logOutButton).Click();
           
        }


    }
}
