using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа запущена");

        Parsing();

        Console.ReadLine();
    }

    private static void Parsing()
    {
        var driver = new ChromeDriver();
        driver.Url = "https://shikimori.one/animes/page/2";

        var listUrlTitle = GetListUrlTitle(driver);
        var listIdTitle = GetListIdTitle(listUrlTitle);
    }

    /// <summary>
    /// Получение списка ссылок на тайты с SHIKIMORI
    /// </summary>
    /// <param name="driver">chromedriver</param>
    /// <returns>List<string> - Список URL</returns>
    private static List<string> GetListUrlTitle(IWebDriver driver)
    {
        var listUrlTitle = new List<string>();
        var arrayImage = driver.FindElements(By.ClassName("anime-tooltip-processed"));
        foreach (var item in arrayImage)
        {
            listUrlTitle.Add(item.GetAttribute("href"));
        }
        return listUrlTitle;
    }

    /// <summary>
    /// Получение списка уникальных номеров тайтлов с SHIKIMORI
    /// </summary>
    /// <param name="driver">chromedriver</param>
    /// <returns>List<string> - Список id</returns>
    private static List<string> GetListIdTitle(List<string> listUrlTitle)
    {
        var listIdTitle = new List<string>();
        foreach (var item in listUrlTitle)
        {
            listIdTitle.Add(item.Remove(0, 29).Split('-')[0]);
        }
        return listIdTitle;
    }
}