using System.IO;

public class Starter
{
    public void Run()
    {
        Actions actions = new Actions();
        Logger logger = Logger.Instance;

        for (int i = 0; i < 100; i++)
        {
            int number = (int)logger.GetRandomLogType();
            Result result = null;

            switch (number)
            {
                case 1:
                    result = actions.Info();
                    break;
                case 2:
                    result = actions.Warning();
                    break;
                case 3:
                    result = actions.Error();
                    break;
            }
        }

        string reports = logger.GetReports();
        File.WriteAllText("log.txt", reports);
    }
}