namespace UITesting
{
    public class Logger
    {
        public Logger()
        {
            
        }

        public void LogMessage(string logFilePath, string message, string typeMessage)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                sw.WriteLine($"[{timestamp}] [{typeMessage}] {message}");
            }
        }
    }
}
