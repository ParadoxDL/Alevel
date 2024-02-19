using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class EventsService
    {
        public delegate void CalcEventHandler(int result);
        public event CalcEventHandler OnCalculated;

        public int CalculateSum(int x, int y)
        {
            int result = x + y;

            if (OnCalculated != null)
            {
                OnCalculated(result);
            }

            return result;
        }

        public static void HandleCalculation(int result)
        {
            Console.WriteLine($"Calculation result: {result}");
        }

        public static void CalculateWithWrapper(EventsService calculator, int x, int y)
        {
            try
            {
                int result = calculator.CalculateSum(x, y);
                int totalSum = result + result;
                Console.WriteLine($"Total Sum: {totalSum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
