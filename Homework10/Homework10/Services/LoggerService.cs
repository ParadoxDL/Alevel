using Services.Interfaces;
using System.IO;

namespace Services
{
    internal class LoggerService : ILoggerService
    {
        private string logFilePath = "log.txt";

        public void Log(string message)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine($"{DateTime.UtcNow}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
}