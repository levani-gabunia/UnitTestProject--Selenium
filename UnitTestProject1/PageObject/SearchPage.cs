using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.PageObject
{
	public class SearchPage
	{
		IWebDriver _driver;
		public SearchPage(IWebDriver driv) //=> _driver = driver;
		{
			this._driver = driv;
		}
		public IWebElement SearchTextbox => _driver.FindElement(By.Name("search_query"));
		public IWebElement SearchButton => _driver.FindElement(By.XPath(".//*[@id='search-icon-legacy']"));
		public ResultPage NavigateToResultPage()
		{
			SearchTextbox.SendKeys("Bakkappa N");
			SearchButton.Click();
			return new ResultPage(_driver);
		}
	}
}
