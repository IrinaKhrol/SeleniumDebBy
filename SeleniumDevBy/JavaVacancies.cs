using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDevBy
{
    internal class JavaVacancies : BasePage
    {
        const string JAVA_VACANCIES_XPATH = "//a[@class='vacancies-list-item__link_block']";

        public JavaVacancies(IWebDriver driver) : base(driver)
        {

        }

        internal int GetVacanciesPage()
        {

            //int vacanciesNumberOnTheMainPage;
            //int vacanciesTextNumberOnTheMainPage;
            //int.TryParse(vacanciesTextNumberOnTheMainPage, out vacanciesNumberOnTheMainPage);
            //int countOnVacanciesPage = 0;
            return _driver.FindElements(By.XPath(JAVA_VACANCIES_XPATH)).Count();

            //foreach (var v in vacancies)
            {
                // countOnVacanciesPage++;
                //return v.Text;
            }
        }
}   }
