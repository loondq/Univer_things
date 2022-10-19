using System;


namespace test
{
    class Program
    {
        static string Result(double x, double eps)
        {
            double k = 1;
            if (Math.Abs(x) < 1)
            {
                double current = 1, previous;
                double sum = 1;
                double p = 1, s = 1;
                do
                {
                    previous = current;
                    current = (-1 * p) * (x * s) * (1 + k);
                    sum += current;
                    k++;
                    p *= -1;
                    s *= x;
                } while (Math.Abs(current - previous) > eps);
                return $"Шаг: {k} Сумма ряда: {sum}";
            }
            else
            {
                return "Недопустимый x";
            }
        }
        static void Main()
        {
            //задание 1.14
            Console.WriteLine("Введите x (|x| < 1)");
            double x = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Введите значение eps (к примеру 0.001)");
            double eps = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(Result(x, eps));
            Console.WriteLine(1.0 / ((1 + x) * (1 + x)));
        }
    }
}
