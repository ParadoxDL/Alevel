namespace Homework_13
{

    internal class Class1
    {
        public delegate void ShowDelegate(bool result);
        public static void DisplayShowDelegate(bool result, ShowDelegate showDelegate)
        {
            showDelegate(result);
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
