namespace UITesting.Test
{
    public class ExerciseTests : UIBase
    {
        /// <summary>
        /// Exercise 1
        /// </summary>
        /// <param name="reportName"> Name of Report. </param>
        [Test, TestCaseSource(typeof(Data), nameof(Data.Exercise1))]
        public void Grid_Column_OptionsIconIsDisplayed(string reportName)
        {
            
        }
    }
}
