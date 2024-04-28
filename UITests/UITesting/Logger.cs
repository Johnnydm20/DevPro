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

        public void LogInventory(string name, string price, string stock)
        {
            string logFilePath = "inventory.log";

            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Name: {name}, Price: {price}, Stock: {stock}");
            }
        }
    }
}
