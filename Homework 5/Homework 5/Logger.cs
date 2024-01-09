using System;

public enum LogType : int { Error = 1, Info = 2, Warning = 3 }

public class Logger
{
    private static Logger instance;
    private string reports;
    private Random random;

    private Logger()
    {
        reports = "";
        random = new Random();
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    public void Log(string message, LogType logType)
    {
        string logTime = DateTime.Now.ToString();
        string log = $"{logTime}: {logType}: {message}";
        Console.WriteLine(log);
        reports += log;
    }

    public string GetReports()
    {
        return reports;
    }

    public LogType GetRandomLogType()
    {
        return (LogType)random.Next(1, 4);
    }
}