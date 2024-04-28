using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace UITesting.Test
{
    public class Data
    {
        public static IEnumerable<TestCaseData> Exercise1()
        {
            yield return new TestCaseData(Resources.Configuration.DATA1);
        }
    }
}
