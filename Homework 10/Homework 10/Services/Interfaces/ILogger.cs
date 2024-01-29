namespace Services.Interfaces
{
    internal interface ILogger
    {
        public void Log(string message)
        {
            var log = $"{DateTime.UtcNow}: {message}";
            Console.WriteLine(log);
        }
    }
}
