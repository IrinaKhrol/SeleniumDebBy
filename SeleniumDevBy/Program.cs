using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutoTest;
using System.Net.Sockets;

//WebDriver driverDevBy = new ChromeDriver();
//Authorization devByPage = new Authorization(driverDevBy);
//devByPage.OpenHomePage();
//System.Threading.Thread.Sleep(3000);
//devByPage.InputEmailandPasswordForEner();
//driverDevBy.Close();

System.Threading.Thread.Sleep(3000);
//WebDriver driver = new ChromeDriver();
//driver.Url = "https://devby.io/";

//System.Threading.Thread.Sleep(3000);

//var vacanciesTextOnTheMainPage = driver.FindElement(By.XPath("/html/body/div[2]/main/div[10]/div[2]/div/div[7]/div")).Text;
//var vacanciesTextNumberOnTheMainPage = vacanciesTextOnTheMainPage.Trim().Split(' ')[0];

//Console.WriteLine(vacanciesTextNumberOnTheMainPage);

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

/*WebDriver driverGoogle = new ChromeDriver();
driverGoogle.Navigate().GoToUrl("https://www.google.com/intl/ru/gmail/about/");

HomePage homePage = new HomePage(driverGoogle);
homePage.OpenLoginPage();

LoginPage loginPage = new LoginPage(driverGoogle);
loginPage.InputEmailInLogin("TSelenium001");
loginPage.InputPasswordInLogin("SELenium");

MailPage mailPage = new MailPage(driverGoogle);
mailPage.NewWriteLetter();
mailPage.NewWriteLetterWhom("TSelenium007@gmail.com");
mailPage.TheTermLetter("hello");
mailPage.NewLetterText("How are you?");
mailPage.SendLetter();

Thread.Sleep(3000); 
mailPage.Exit();


loginPage.InputEmailInLogin("TSelenium007");
loginPage.InputPasswordInLogin("SELenium");
mailPage.ReloadPage();
mailPage.OpenFirstLetter();
var term = mailPage.OpenTermLetter();
Console.WriteLine(term);
var textLetter = mailPage.OpenTextLetter();
Console.WriteLine(textLetter);
mailPage.AnswerLetter();
mailPage.PrintAnswerText("bye");
mailPage.SendAnswerLetter();

Thread.Sleep(3000);
mailPage.Exit();


loginPage.InputEmailInLogin("TSelenium001");
loginPage.InputPasswordInLogin("SELenium");
mailPage.ReloadPage();
mailPage.OpenFirstLetter();
var term2 = mailPage.OpenTermLetter();
mailPage.OpenTextLetter();

Thread.Sleep(3000);
mailPage.Exit();
driverGoogle.Close();*/







