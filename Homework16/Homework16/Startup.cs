using Services;
using static Enum.StateEnum;

namespace Homework16
{
    internal class Startup
    {
        public void Start()
        {
            MessageBoxService messageBox = new MessageBoxService();

            messageBox.WindowClosedEvent += (sender, state) =>
            {
                if (state == State.Ok)
                {
                    Console.WriteLine("The operation has been confirmed");
                }
                else if (state == State.Cancel)
                {
                    Console.WriteLine("The operation was rejected");
                }
            };

            messageBox.Open();

            Console.ReadLine();
        }
    }
}
