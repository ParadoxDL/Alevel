namespace Services.Abstractions
{
    internal interface ILoggerService
    {
        event EventHandler BackupNeeded;
        Task AddLogAsync(string message);
        Task CreateBackupAsync();
        Task GetLogsAsync(int count);
    }
}
