namespace UITesting.Test
{
    public class ExerciseTests : UIBase
    {
        /// <summary>
        /// Exercise 1
        /// </summary>
        /// <param name="reportName"> Name of Report. </param>
        [Test, TestCaseSource(typeof(Data), nameof(Data.Exercise1))]
        public void Exercise1_ExpectedResutl(string reportName)
        {
            // Initialize logger
            Logger logger = new Logger();

            // LogMessage messages
            logger.LogMessage("application.log", "User logged in", "INFO");
            logger.LogMessage("application.log", "Failed login attempt", "WARNING");
            logger.LogMessage("application.log", "User logged in", "INFO");
            logger.LogMessage("application.log", "User updated info", "INFO");
        }
    }
}
