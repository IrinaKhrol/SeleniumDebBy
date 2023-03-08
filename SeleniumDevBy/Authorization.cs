using OpenQA.Selenium;

namespace SeleniumAutoTest
{
    internal class Authorization
    {
        IWebDriver _driverDevBy;

        const string SITE_HOMEPAGE_XPATH = "//a[@href='https://id.devby.io/@/hello']";
        const string SITE_EMAIL_XPATH = "//input[@class='input']";
        const string SITE_PASSWORD_XPATH = "//input[@name='password']";
        const string SITE_ENTER_XPATH = "//span[@class='button__content']";


        public Authorization(IWebDriver driverDevBy) 
        {
            _driverDevBy = driverDevBy;
            _driverDevBy.Url = "https://devby.io/";
            _driverDevBy.Manage().Window.Maximize();
        }


        public void OpenHomePage()
        {
            var homePage = _driverDevBy.FindElement(By.XPath(SITE_HOMEPAGE_XPATH));
            homePage.Click();
        }

        public void InputEmailandPasswordForEner() 
        {
            var email = _driverDevBy.FindElement(By.XPath(SITE_EMAIL_XPATH));
            email.SendKeys("irina1945.2010@mail.ru");

            var password = _driverDevBy.FindElement(By.XPath(SITE_PASSWORD_XPATH));
            password.SendKeys("123456");

            var enter = _driverDevBy.FindElement(By.XPath(SITE_ENTER_XPATH));
            enter.Click();
        }
    }
}
