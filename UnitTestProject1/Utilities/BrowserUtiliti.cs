using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1.Utilities
{
	class BrowserUtiliti
	{
		public IWebDriver intializer(IWebDriver driver)
		{
			driver = new ChromeDriver();
			driver.Url = "https://facebook.com";
			return driver;
		}
	}
}
