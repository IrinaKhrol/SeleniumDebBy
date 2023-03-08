using OpenQA.Selenium;
using SeleniumAutoTes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutoTest
{
    internal class HomePageDevBy : BasePageDevBy
    {
        const string VACANCIES_TEXT_ON_THE_MAIN_PAGE = "/html/body/div[2]/main/div[10]/div[2]/div/div[7]/div";
        const string VACANCIES_BUTTON = "//a[@href='https://jobs.dev.by/?filter[specialization_title]=Java']";
        const string VACANCIES_INFORMATION = "//a[@class='vacancies-list-item__link_block']";

        public HomePageDevBy(IWebDriver driver) : base(driver)
        {
            GoToUrl("https://devby.io/");
        }

        public void OpenVacancies()
        {
            var vacanciesButton = _driver.FindElement(By.XPath(VACANCIES_BUTTON));
            vacanciesButton.Click();
        }

        internal string GetVacanciesTheMainPage()
        {
            var vacanciesTextOnTheMainPage = _driver.FindElement(By.XPath(VACANCIES_TEXT_ON_THE_MAIN_PAGE)).Text;
            var vacanciesTextNumberOnTheMainPage = vacanciesTextOnTheMainPage.Trim().Split(' ')[0];
            return vacanciesTextNumberOnTheMainPage;
        }

        internal int GetVacanciesPage()
        {

            //int vacanciesNumberOnTheMainPage;
            //int vacanciesTextNumberOnTheMainPage;
            //int.TryParse(vacanciesTextNumberOnTheMainPage, out vacanciesNumberOnTheMainPage);
            //int countOnVacanciesPage = 0;
            return _driver.FindElements(By.XPath(VACANCIES_INFORMATION)).Count();

            //foreach (var v in vacancies)
            {
               // countOnVacanciesPage++;
                //return v.Text;
            }
        }
    }       
}

