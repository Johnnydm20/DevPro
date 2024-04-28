﻿namespace UITesting
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
                // Get current timestamp
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Write message with timestamp to the log file
                sw.WriteLine($"[{timestamp}] [{typeMessage}] {message}");
            }
        }
    }
}