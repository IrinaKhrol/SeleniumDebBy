using OpenQA.Selenium;

namespace SeleniumDevBy
{
    internal class HomePage : BasePage
    {
        const string VACANCIES_TEXT_ON_THE_MAIN_PAGE = "/html/body/div[2]/main/div[10]/div[2]/div/div[7]/div";
        const string VACANCIES_BUTTON = "//a[@title='Java']";

        public HomePage(IWebDriver driver) : base(driver)
        {
            GoToUrl("https://devby.io/");
        }

        public void OpenVacancies()
        {
            var vacanciesButton = _driver.FindElement(By.XPath(VACANCIES_BUTTON));
            vacanciesButton.Click();
        }

        internal int GetVacanciesTheMainPage()
        {           
            var vacanciesTextOnTheMainPage = _driver.FindElement(By.XPath(VACANCIES_TEXT_ON_THE_MAIN_PAGE)).Text;
            var vacanciesTextNumberOnTheMainPage = vacanciesTextOnTheMainPage.Trim().Split(' ')[0];
            int vacanciesNumberOnTheMainPage;
            int.TryParse(vacanciesTextNumberOnTheMainPage, out vacanciesNumberOnTheMainPage);
            return vacanciesNumberOnTheMainPage;
        }
    }       
}

