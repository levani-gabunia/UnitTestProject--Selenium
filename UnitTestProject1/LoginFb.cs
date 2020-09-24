using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using UnitTestProject1.BaseClass;

namespace UnitTestProject1
{
	[TestClass]
	public class FbTest  : BaseTest
	{
		[Test,Category("chemi testi")]
		public void NavigateToResultPage()
		{
			try
			{
				IWebElement loginTextField = _driver.FindElement(By.XPath("//*[@id='email']"));
				loginTextField.SendKeys("levanjke N");
				IWebElement passwordTextField = _driver.FindElement(By.XPath("//*[@id='pass']"));
				passwordTextField.SendKeys("ablava");
				IWebElement loginButton = _driver.FindElement(By.XPath("//*[@id='u_0_b']"));
				loginButton.Click();
				Thread.Sleep(5555);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				throw;
			}
			finally
			{
				ITakesScreenshot ts = (ITakesScreenshot)_driver;
				Screenshot screenshot = ts.GetScreenshot();
				screenshot.SaveAsFile(@"C:\Users\levan\OneDrive\Desktop\UnitTestProject1\UnitTestProject1\ScreenShot\SH.Jpeg", ScreenshotImageFormat.Jpeg);
				if (_driver != null)
					_driver.Quit();
			}
		}
	}
}
