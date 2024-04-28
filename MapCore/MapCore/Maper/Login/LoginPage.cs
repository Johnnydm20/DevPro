using Common;
using MapCore.Maper.BasicObject;
using OpenQA.Selenium;

namespace MapCore.Maper.Login
{
    public class LoginPage
    {
        public ButtonObject LoginButton { get; set; }
        public InputObject UserNameInput { get; set; }
        public InputObject PasswordInput { get; set; }
        public ButtonObject UserNameLabel { get; set; }
        public ButtonObject InvalidUserLabel { get; set; }

        public LoginPage()
        {
            LoginButton = new ButtonObject(By.Id(LocatorManager.BTN_LOGIN));
            UserNameInput = new InputObject(By.CssSelector(LocatorManager.USER_NAME_INPUT));
            PasswordInput = new InputObject(By.Id(LocatorManager.PASSWORD_INPUT));
            UserNameLabel = new ButtonObject(By.Id(LocatorManager.USER_NAME_LABEL));
            InvalidUserLabel = new ButtonObject(By.Id(LocatorManager.INVALID_USER_LABEL));
        }

        public void NavigateToDemoQA()
        {
            Browser.CreateWebDriver();
            Browser.NavigateTo(@"https://demoqa.com/login");
        }
    }
}
