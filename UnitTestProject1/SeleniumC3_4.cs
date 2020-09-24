using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestFixture]

	class SeleniumC3_4
	{
		[Test]
		[Author("Levan gabunia", "levani-gabunia95@mail.ru")]
		[Description("Fb Login Verify")]
		[TestCaseSource("DataDriverTesting")] //ramodenime Urls micema
		public void Test1(string urlNames)
		{
			IWebDriver _driver = null;
			try
			{
				_driver = new ChromeDriver();
				//driver.Url = "https://facebook.com";
				_driver.Url = urlNames;
				//IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='eeeemail']"));
				IWebElement emailTextField = _driver.FindElement(By.XPath(".//*[@id='email']"));
				emailTextField.SendKeys("Selenium C#");
				_driver.Quit();
			}
			catch (Exception ex)
			{
				ITakesScreenshot ts = (ITakesScreenshot)_driver; //screenshotis gadageba
				Screenshot screenshot = ts.GetScreenshot();
				screenshot.SaveAsFile(@"C:\Users\levan\OneDrive\Desktop\UnitTestProject1\UnitTestProject1\ScreenShot\SH(1).Jpeg", ScreenshotImageFormat.Jpeg);
				Console.WriteLine(ex.StackTrace);
				throw;
			}
			finally
			{
				if (_driver != null)
					_driver.Quit();
			}

		}
		static IList DataDriverTesting()
		{
			ArrayList arr = new ArrayList();
			arr.Add("https://facebook.com");
			//arr.Add("https://youtube.com");
			//arr.Add("https://gmail.com");
			return arr;
		}
		//[Test]
		//[Author("Levan gabunia", "levani-gabunia95@mail.ru")]
		//[Description("Fb Login Verify3333333333")]
		//public void Test2()
		//{
		//	IWebDriver driver = new ChromeDriver();
		//	driver.Url = "https://facebook.com";
		//	IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
		//	emailTextField.SendKeys("Selenium C#");
		//	driver.Quit();
		//}
	}
}
