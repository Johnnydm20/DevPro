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
            //Login to dReveal
            DevProMap.Login.LogIntoXXX();

            //Close browser
            DevProMap.CloseBrowser();
        }
    }
}
