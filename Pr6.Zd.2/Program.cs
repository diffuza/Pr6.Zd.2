using System;
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите значение переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            Console.WriteLine("Введите значение переменной y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1}", -x, y);
            double S;
            S = -x * y;
            Console.WriteLine("S= -x*y = {0}", S);

        }
    }
}
