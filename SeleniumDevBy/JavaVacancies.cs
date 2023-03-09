using OpenQA.Selenium;

namespace SeleniumDevBy
{
    internal class JavaVacancies : BasePage
    {
        const string JAVA_VACANCIES_XPATH = "//a[@class='vacancies-list-item__link_block']";

        public JavaVacancies(IWebDriver driver) : base(driver)
        {
            GoToUrl("https://jobs.dev.by/?filter[specialization_title]=Java");
        }

        internal int GetVacanciesPage()
        {
            return _driver.FindElements(By.XPath(JAVA_VACANCIES_XPATH)).Count;
        }
    }
}
