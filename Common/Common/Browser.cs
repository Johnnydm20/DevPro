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
        static string[] argumentsToAdd = { "--start-maximized" };

        /// <summary>
        /// Create and Initialize WebDriver.
        /// </summary>
        /// <returns>IWebDriver interface initialized</returns>
        public static IWebDriver CreateWebDriver()
        {
            IWebDriver driver;
            ChromeOptions preferences = new ChromeOptions();
            preferences.AddArguments(argumentsToAdd);
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(GetChromeDriverFullPath(), preferences);
            drivers.TryAdd(Thread.CurrentThread, driver);

            return driver;
        }

        /// <summary>
        /// Get the Chrome driver full path.
        /// </summary>
        /// <returns>Chrome driver full path.</returns>
        private static string GetChromeDriverFullPath()
        {
            var chromeConfig = new ChromeConfig();
            var chromeFolderName = chromeConfig.GetName();
            var chromeLatestVersion = chromeConfig.GetLatestVersion();
            var chromeArchitecture = "X64";

            var chromeFullPath = AppDomain.CurrentDomain.BaseDirectory + chromeFolderName + "\\" + chromeLatestVersion + "\\" + chromeArchitecture;
            return chromeFullPath;
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
        /// Close Browser and clear driver.
        /// </summary>
        public static void CloseBrowser()
        {
            Close();
            drivers.Clear();
        }
    }
}