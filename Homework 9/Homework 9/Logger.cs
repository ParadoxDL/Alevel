using Homework_9.Services;

namespace Homework_9
{
    class Logger
    {
        private readonly FileService fileService;

        public Logger(FileService fileService)
        {
            this.fileService = fileService;
        }

        public void Log(string logType, string message)
        {
            string logTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt");
            string logEntry = $"{logTime}: {logType}: {message}";
            Console.WriteLine(logEntry);
            fileService.WriteToFile(logEntry);
        }
    }
}
