using Homework_9.Services;

namespace Homework_9
{
    class App
    {
        public static void Run()
        {
            FileService fileService = new FileService(@"C:\MyLogs");
            Logger logger = new Logger(fileService);
            Actions actions = new Actions(logger);

            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int randomType = random.Next(1, 4);

                switch (randomType)
                {
                    case 1:
                        actions.Info();
                        break;
                    case 2:
                        actions.Warning();
                        break;
                    case 3:
                        actions.Error();
                        break;
                }
            }
        }
    }
}
