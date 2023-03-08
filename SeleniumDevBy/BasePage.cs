using OpenQA.Selenium;

namespace SeleniumDevBy
{
    internal abstract class BasePage
    {
         public IWebDriver _driver;

        public BasePage(IWebDriver driver) 
        {
            _driver = driver;
        }

        protected void GoToUrl(string url) 
        {
            _driver.Url= url;
            _driver.Manage().Window.Maximize();
        }



    }
}
