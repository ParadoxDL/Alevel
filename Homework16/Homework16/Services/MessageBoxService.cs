using static Enum.StateEnum;

namespace Services
{
    internal class MessageBoxService
    {
        public delegate void WindowClosedEventHandler(object sender, State state);

        public event WindowClosedEventHandler WindowClosedEvent;

        public async void Open()
        {
            Console.WriteLine("Window is open");

            await Task.Delay(3000);

            Console.WriteLine("Window was closed by the user");

            Random random = new Random();
            State state = (random.Next(0, 2) == 0) ? State.Ok : State.Cancel;

            GetWindowClosed(state);
        }

        protected virtual void GetWindowClosed(State state)
        {
            WindowClosedEvent?.Invoke(this, state);
        }
    }
}
