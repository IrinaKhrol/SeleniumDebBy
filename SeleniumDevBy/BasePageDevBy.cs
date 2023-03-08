using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutoTes
{
    internal abstract class BasePageDevBy
    {
         public IWebDriver _driver;

        public BasePageDevBy(IWebDriver driver) 
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
