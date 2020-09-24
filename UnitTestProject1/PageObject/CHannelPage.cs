using MongoDB.Bson;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObject
{
	public class ChannelPage
	{
		IWebDriver _driver;
		public ChannelPage(IWebDriver driver) => _driver = driver;
		public IWebElement ChannelName => _driver.FindElement(By.XPath("//yt-formatted-string[@id='text']/yt-formatted-string"));//ubralod teqsti vermoaq youtubidan
		public string GetCHannelName()
		{
			Thread.Sleep(10000);
			return ChannelName.Text;
		}
	}
}
