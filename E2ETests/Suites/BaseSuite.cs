using Core.Waits;
using Core.WebDriver;
using NUnit.Framework;
using System.Configuration;

namespace E2ETests.Suites
{
    public class BaseSuite
    {
        [SetUp]
        public void InitialSetUp()
        {
            WebDriver.Start();
            WebDriver.MaximizeWindow();
            WebDriver.Navigate(ConfigurationManager.AppSettings["baseUrl"]);
            Wait.ForPageReadyState();
        }

        [TearDown]
        public void ShutDown()
        {
            WebDriver.Close();
            WebDriver.Quit();
        }
    }
}
