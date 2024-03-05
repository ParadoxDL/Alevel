namespace Homework_13
{

    internal class Program
    {
        public delegate bool ResultDelegate(int i);
        private static void Show(bool result)
        {
            Console.WriteLine($"Result: {result}");
        }
        static void Main(string[] args)
        {
            ResultDelegate resultDelegate = Class2.Result;
            Class1.ShowDelegate showDelegate = Show;
            Class1.DisplayShowDelegate(resultDelegate(2), showDelegate);
        }
    }
}
