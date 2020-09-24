using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1.BaseClass
{
	public class BaseTest
	{
		public IWebDriver _driver;
		[SetUp] //startav /OneTimeSetUp ertxel marto
		public void open() 
		{
			_driver = new ChromeDriver();
			_driver.Url = "https://youtube.com";
			_driver.Manage().Window.Maximize();
		}
		[TearDown] //afinisheb /OneTimeTearDown 
		public void Cloes()
		{
			_driver.Quit();
		}
	}
}
