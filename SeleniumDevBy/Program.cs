using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDevBy;
using System.Net.Sockets;

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
homePage.GetVacanciesTheMainPage();
JavaVacancies javaVacancies = new JavaVacancies(driver);
javaVacancies.GetVacanciesPage();

var vacanciesTextOnTheMainPage = driver.FindElement(By.XPath("/html/body/div[2]/main/div[10]/div[2]/div/div[7]/div")).Text;
var vacanciesTextNumberOnTheMainPage = vacanciesTextOnTheMainPage.Trim().Split(' ')[0];

Console.WriteLine(vacanciesTextNumberOnTheMainPage);

//int vacanciesNumberOnTheMainPage;
//int.TryParse(vacanciesTextNumberOnTheMainPage, out vacanciesNumberOnTheMainPage);

//var vacanciesButton = driver.FindElement(By.XPath("//a[@href='https://jobs.dev.by/?filter[specialization_title]=Java']"));
//driver.Manage().Window.Maximize();
//vacanciesButton.Click();

//driver.Url = "https://jobs.dev.by/?filter[specialization_title]=Java";

//var vacancies = driver.FindElements(By.XPath("//a[@class='vacancies-list-item__link_block']"));
//int countOnVacanciesPage = 0;
//foreach (var v in vacancies)
{
    //countOnVacanciesPage++;
    //Console.WriteLine(v.Text);
}

//Console.WriteLine(countOnVacanciesPage);
//Console.WriteLine(vacanciesNumberOnTheMainPage);


//if (vacanciesNumberOnTheMainPage > countOnVacanciesPage)
{
   // Console.WriteLine("bug");
}

//if (vacanciesNumberOnTheMainPage < countOnVacanciesPage) 
{
    Console.WriteLine("bug");
}

//if (vacanciesNumberOnTheMainPage == countOnVacanciesPage) 
{
    //Console.WriteLine("number are the same");
}









