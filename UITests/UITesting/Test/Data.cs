using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace UITesting.Test
{
    public class Data
    {
        public static IEnumerable<TestCaseData> LoginSuccessfully()
        {
            yield return new TestCaseData(Resources.Configuration.User1, Resources.Configuration.User1_Password);
            yield return new TestCaseData(Resources.Configuration.User2, Resources.Configuration.User2_Password);
        }
        public static IEnumerable<TestCaseData> LoginFailed()
        {
            yield return new TestCaseData(Resources.Configuration.User3, Resources.Configuration.User3_Password);
            yield return new TestCaseData(Resources.Configuration.User4, Resources.Configuration.User4_Password);
        }
    }
}
