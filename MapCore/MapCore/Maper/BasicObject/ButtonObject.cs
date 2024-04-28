using Common.Selenium;
using OpenQA.Selenium;

namespace MapCore.Maper.BasicObject
{
    public class ButtonObject
    {
        private By Locator { get; set; }

        public ButtonObject(By locator)
        {
            Locator = locator;
        }

        public virtual bool IsDisplayed => DriverHelper.ElementIsDisplayed(Locator);

        public void Click()
        {
            DriverHelper.Click(Locator);
        }
    }
}
