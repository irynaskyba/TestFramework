using Core.Wait;
using Core.WebDriver;
using NUnit.Framework;
using System.Configuration;

namespace E2ETests.Suites
{
    public class NbaSuite : BaseSuite
    {
        [SetUp]
        public void NbaSetUp()
        {
            WebDriver.Navigate(ConfigurationManager.AppSettings["nbaUrl"]);
            Wait.ForPageReadyState();
        }
    }
}
