namespace UITesting
{
    public class Logger
    {
        public Logger()
        {
            
        }

        /// <summary>
        /// Test method that write messages into a log file.
        /// Note. This method is used in Task 1: Logger
        /// </summary>
        /// <param name="logFilePath"> Name and extension of file. </param>
        /// <param name="message"> Message to be saved. </param>
        /// <param name="typeMessage"> Type of message to be saved. </param>
        public void LogMessage(string logFilePath, string message, string typeMessage)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                sw.WriteLine($"[{timestamp}] [{typeMessage}] {message}");
            }
        }

        /// <summary>
        /// Test method that write messages into a inventory.log file.
        /// Note. Task 2: Inventory Management
        /// </summary>
        /// <param name="name"> Name of product. </param>
        /// <param name="price"> Price of product. </param>
        /// <param name="stock"> Stock of product. </param>
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
