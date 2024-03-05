using Newtonsoft.Json;
using Services;
using Services.Abstractions;
using Models;

namespace Homework17
{
    internal class App
    {
        static async Task Main()
        {
            string logFile = "log.txt";
            string backupFolder = "Backup";
            string configFile = "config.json";

            IConfigService configGenerator = new ConfigSevice();
            configGenerator.GenerateConfig(configFile);

            Number appConfig = JsonConvert.DeserializeObject<Number>(File.ReadAllText(configFile));

            ILoggerService logger = new LoggerService(logFile, backupFolder, appConfig.ConfigNumber);

            logger.BackupNeeded += async (sender, args) => await logger.CreateBackupAsync();

            Task task1 = logger.GetLogsAsync(50);

            Task task2 = logger.GetLogsAsync(50);

            await Task.WhenAll(task1, task2);

            Console.WriteLine("Logging complete.");

            await logger.CreateBackupAsync();

            Console.WriteLine("Backup complete.");
        }
    }
}
