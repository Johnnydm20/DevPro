using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Concurrent;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Common
{
    public class Browser
    {
        static ConcurrentDictionary<Thread, IWebDriver> drivers = new ConcurrentDictionary<Thread, IWebDriver>();
        
        /// <summary>
        /// Create and Initialize WebDriver.
        /// </summary>
        /// <returns>IWebDriver interface initialized</returns>
        public static IWebDriver CreateWebDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        /// <summary>
        /// Navigate to a given URL.
        /// </summary>
        /// <param name="url"> URL </param>
        public static void NavigateTo(string url)
        {
            GetDriver().Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Close Browser.
        /// </summary>
        private static void Close()
        {
            GetDriver().Quit();
        }

        /// <summary>
        /// Get WebDriver.
        /// </summary>
        /// <returns>IWebDriver interface</returns>
        public static IWebDriver GetDriver()
        {
            IWebDriver selecDriver;
            if (drivers.TryGetValue(Thread.CurrentThread, out selecDriver))
            {
                return selecDriver;
            }
            else
            {
                throw new InvalidCastException("Driver could not be obtained");
            }
        }
    }
}