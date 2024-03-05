namespace Homework_13
{
    internal class Class2
    {
        public delegate int MultiplyDelegate(int x, int y);
        public delegate bool CalcReturn(int i);
        public static CalcReturn Calc(MultiplyDelegate multiplyDelegate, int x, int y)
        {
            int result = multiplyDelegate(x, y);

            return new CalcReturn(Result);
        }
        public static bool Result(int i)
        {
            int result = Class1.Multiply(7, 4);
            int residue = result % i;

            return residue == 0;
        }
    }
}
