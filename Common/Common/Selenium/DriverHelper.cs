using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Common.Selenium
{
    public class DriverHelper
    {
        /// <summary>
        /// Method to Set Text.
        /// </summary>
        /// <param name="locator"> Locator of webElement </param>
        /// <param name="text"> String to be entered</param>
        public static void SetText(By locator, string text)
        {
            try
            {
                var webElement = Browser.GetDriver().FindElement(locator);
                webElement.Clear();
                webElement.SendKeys(text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clear Input Text.
        /// </summary>
        /// <param name="locator"> Locator of webElement </param>
        public static void Clear(By locator)
        {
            try
            {
                if (ElementIsDisplayed(locator))
                {
                    var webElement = Browser.GetDriver().FindElement(locator);
                    webElement.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Click element.
        /// </summary>
        /// <param name="locator"> Locator of webElement </param>
        public static void Click(By locator)
        {
            try
            {
                var webElement = Browser.GetDriver().FindElement(locator);
                webElement.Click();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Verify if an element is displayed.
        /// </summary>
        /// <param name="locator"> Locator of webElement </param>
        /// <param name="timeOut"> Time in seconds to await until element is Clickable. Default to 20 seconds </param>
        /// <returns> True or False </returns>
        public static bool ElementIsDisplayed(By locator, int timeOut = 20)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(timeOut));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                var element = wait.Until(driver => Browser.GetDriver().FindElement(locator));

                return element.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
