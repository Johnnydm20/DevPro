using Common;
using MapCore.Maper.Login;

namespace MapCore
{
    public class DevProMap
    {
        public LoginPage Login { get; private set; }

        public DevProMap()
        {
            Login = new LoginPage();
        }

        public void CloseBrowser()
        {
            Browser.CloseBrowser();
        }
    }
}
