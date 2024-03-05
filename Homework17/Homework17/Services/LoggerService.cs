using Services.Abstractions;

namespace Services
{
    internal class LoggerService : ILoggerService
    {
        public event EventHandler BackupNeeded;

        private readonly string logFile;
        private readonly string backupFolder;
        private readonly int сonfigNumberFile;

        private List<string> logBuffer;

        public LoggerService(string logFile, string backupFolder, int сonfigNumberFile)
        {
            this.logFile = logFile;
            this.backupFolder = backupFolder;
            this.сonfigNumberFile = сonfigNumberFile;

            logBuffer = new List<string>();
        }

        public async Task AddLogAsync(string message)
        {
            logBuffer.Add($"{DateTime.Now} - {message}");

            if (logBuffer.Count >= сonfigNumberFile)
            {
                await GetLogBufferAsync();
                BackupNeeded?.Invoke(this, EventArgs.Empty);
            }
        }

        private async Task GetLogBufferAsync()
        {
            if (logBuffer.Count > 0)
            {
                using (StreamWriter writer = File.AppendText(logFile))
                {
                    foreach (string logEntry in logBuffer)
                    {
                        await writer.WriteLineAsync(logEntry);
                    }
                }

                logBuffer.Clear();
            }
        }
        public async Task CreateBackupAsync()
        {
            await GetLogBufferAsync();
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            string uniqueId = Guid.NewGuid().ToString().Substring(0, 8);
            string backupFileName = $"{DateTime.Now:yyyyMMddHHmmss}_{uniqueId}_Backup.txt";
            string backupFilePath = Path.Combine(backupFolder, backupFileName);

            File.Copy(logFile, backupFilePath);
        }

        public async Task GetLogsAsync(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                await AddLogAsync($"Log {i}");
            }
        }
    }
}
