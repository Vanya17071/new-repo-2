using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());


        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, точка пересечения не существует.");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
        }

        Console.ReadKey();
    }
}                                                                                                                                     