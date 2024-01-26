namespace Homework_9.Services
{
    class FileService
    {
        private readonly string logDirectory;
        private const int maxLogFile = 3;

        public FileService(string myDirectory)
        {
            if (!Directory.Exists(myDirectory))
            {
                Directory.CreateDirectory(myDirectory);
            }

            this.logDirectory = myDirectory;
        }

        public void WriteToFile(string logEntry)
        {
            string fileName = $"{DateTime.Now:MM-dd-yyyy_hh-mm-ss-fff_tt}.txt";
            string filePath = Path.Combine(logDirectory, fileName);

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(logEntry);
            }

            RemoveOldFiles();
        }

        private void RemoveOldFiles()
        {
            string[] logFiles = Directory.GetFiles(logDirectory);
            if (logFiles.Length > maxLogFile)
            {
                Array.Sort(logFiles);
                File.Delete(logFiles[0]);
            }
        }
    }
}
