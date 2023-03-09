using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDevBy;


//WebDriver driverDevBy = new ChromeDriver();
//Authorization devByPage = new Authorization(driverDevBy);
//devByPage.OpenHomePage();
//System.Threading.Thread.Sleep(3000);
//devByPage.InputEmailandPasswordForEner();
//driverDevBy.Close();

System.Threading.Thread.Sleep(3000);
WebDriver driver = new ChromeDriver();
HomePage homePage = new HomePage(driver);
homePage.OpenVacancies();
var vacanciesNumberOnTheMainPage = homePage.GetVacanciesTheMainPage();
JavaVacancies javaVacancies = new JavaVacancies(driver);
var countOnVacanciesPage = javaVacancies.GetVacanciesPage();

// Print data to console
Console.WriteLine(countOnVacanciesPage);
Console.WriteLine(vacanciesNumberOnTheMainPage);
Console.WriteLine(vacanciesNumberOnTheMainPage == countOnVacanciesPage);


if (vacanciesNumberOnTheMainPage > countOnVacanciesPage)
{
     Console.WriteLine("bug");
}

if (vacanciesNumberOnTheMainPage < countOnVacanciesPage) 
{
    Console.WriteLine("bug");
}

if (vacanciesNumberOnTheMainPage == countOnVacanciesPage) 
{
    Console.WriteLine("number are the same");
}









