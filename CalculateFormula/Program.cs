namespace CalculateFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFormula(0.8)); // пример вычисления формулы

            Console.ReadLine();
        }

        static double CalculateFormula(double x)
        {
            if (x >= 0.9)
            {
                return 1 / Math.Pow((0.1 + x), 2);
            }
            else if (x < 0.9 && x >= 0)
            {
                return 0.2 * x + 0.1;
            }
            else
            {
                return Math.Pow(x, 2) + 0.2;
            }
        }
    }
}
