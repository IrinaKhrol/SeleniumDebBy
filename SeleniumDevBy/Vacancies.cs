using OpenQA.Selenium;

namespace SeleniumAutoTest
{
    internal class Vacancies
    {
        IWebDriver _driverDevBy;

        const string VACANCIES_JAVA_TEXT_MAIN_PAIGE_XPATH = "/html/body/div[2]/main/div[10]/div[2]/div/div[7]/div";
        const string VACANCIES_JAVA_BUTTON_XPATH = "//a[@href='https://jobs.dev.by/?filter[specialization_title]=Java']";
        const string VACANCIES_JAVA_ANOTHER_PAIGE_XPATH = "//a[@class='vacancies-list-item__link_block']";
    }
}
