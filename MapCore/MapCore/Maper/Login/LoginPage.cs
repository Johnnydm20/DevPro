using Common;
using MapCore.Maper.BasicObject;
using OpenQA.Selenium;

namespace MapCore.Maper.Login
{
    public class LoginPage
    {
        public ButtonObject LoginButton { get; set; }

        public LoginPage()
        {
            LoginButton = new ButtonObject(By.CssSelector(LocatorManager.ADMIN_CULTURE_USER_BTN_LOGIN));
        }

        public void LogIntoXXX()
        {
            Browser.CreateWebDriver();
            //Browser.NavigateTo(@"http://20.80.227.172/embedded/develop/integration");
            Browser.NavigateTo(@"http://localhost/Integration/Login");
            LoginButton.Click();
        }
    }
}
