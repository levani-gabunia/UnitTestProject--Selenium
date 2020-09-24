using NUnit.Framework;
using System.Threading;
using UnitTestProject1.BaseClass;
using UnitTestProject1.PageObject;

namespace UnitTestProject1.TestScripts
{
	[TestFixture]
	public class Module1 : BaseTest
	{
		[Test]
		public void TestMethod1()
		{
			var searchPage = new SearchPage(_driver);
			var resultPage = searchPage.NavigateToResultPage();
			var channelPageText = resultPage.GetToChannel();
			string actualCHannelName = channelPageText.GetCHannelName();
			string exceptedChannelName = "Bakkappa N - TheTechie AutomationLaboratory";
			Assert.IsTrue(actualCHannelName.Equals(exceptedChannelName));
			Thread.Sleep(3333);
		}
	}
}
