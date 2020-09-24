using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObject
{
	public class ResultPage
	{
		IWebDriver _driver;
		public ResultPage(IWebDriver driver) => _driver = driver;
		public IWebElement ChannelNameLinkText => _driver.FindElement(By.LinkText("Bakkappa N - TheTechie AutomationLaboratory"));
		public ChannelPage GetToChannel()
		{
			Thread.Sleep(3000);
			ChannelNameLinkText.Click();
			return new ChannelPage(_driver);
		}
	}
}
