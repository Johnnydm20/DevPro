using Common.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapCore.Maper.BasicObject
{
    public class InputObject
    {
        private By Locator { get; set; }

        public InputObject(By locator)
        {
            Locator = locator;
        }

        public void Click()
        {
            DriverHelper.Click(Locator);
        }

        public void SetText(string text)
        {
            DriverHelper.SetText(Locator, text);
        }

        public void Clear()
        {
            DriverHelper.Clear(Locator);
        }
    }
}
