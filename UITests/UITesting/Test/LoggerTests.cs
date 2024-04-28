namespace UITesting.Test
{
    public class LoggerTests : UIBase
    {
        Logger logger = new Logger();

        /// <summary>
        /// Task 1.1 Test N°1
        /// </summary>
        /// <param name="userName"> user name to login. </param>
        /// <param name="userPassword"> password to login. </param>
        [Test, TestCaseSource(typeof(Data), nameof(Data.LoginSuccessfully))]
        public void Task1_LoginSuccessfully(string userName, string userPassword)
        {
            //Go to DemoQA site
            DevProMap.Login.NavigateToDemoQA();

            //Enter the user name
            DevProMap.Login.UserNameInput.SetText(userName);

            //Type the user password
            DevProMap.Login.PasswordInput.SetText(userPassword);

            //Click on Login button
            DevProMap.Login.LoginButton.Click();

            //Verify if User Name label is displayed
            Assert.That(DevProMap.Login.UserNameLabel.IsDisplayed, Is.True);

            // LogMessage messages
            logger.LogMessage("application.log", "User logged in", "INFO");

            //Kill the browser process
            DevProMap.CloseBrowser();
        }

        /// <summary>
        /// Task 1.1 Test N°2
        /// </summary>
        /// <param name="userName"> user name to login. </param>
        /// <param name="userPassword"> password to login. </param>
        [Test, TestCaseSource(typeof(Data), nameof(Data.LoginFailed))]
        public void Task1_LoginFailed(string userName, string userPassword)
        {
            //Go to DemoQA site
            DevProMap.Login.NavigateToDemoQA();

            //Enter the user name
            DevProMap.Login.UserNameInput.SetText(userName);

            //Type the user password
            DevProMap.Login.PasswordInput.SetText(userPassword);

            //Click on Login button
            DevProMap.Login.LoginButton.Click();

            //Verify if User Name label is displayed
            Assert.That(DevProMap.Login.InvalidUserLabel.IsDisplayed, Is.False);

            // LogMessage messages
            logger.LogMessage("application.log", "Failed login attempt", "WARNING");

            //Kill the browser process
            DevProMap.CloseBrowser();
        }
    }
}
