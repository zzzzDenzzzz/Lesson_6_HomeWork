using System;

namespace Task_2
{
    internal class Trapezoid : GeometricFigure, IFigure
    {
        int height;
        int baseLength;

        public Trapezoid() : base()
        {
            height = 5;
            baseLength = 5;
        }

        public void Draw()
        {
            ConsoleFigure();
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($"{new string(' ', height - i - 1)}{new string(SYMBOL, baseLength + 2 * i)}");
            }
            Console.ResetColor();
        }

        public void Size()
        {
            Console.WriteLine("Height trapezoid: ");
            if (int.TryParse(Console.ReadLine(), out int height))
            {
                if (height > 0)
                {
                    this.height = height;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException();
            }

            Console.WriteLine("Base length trapezoid: ");
            if (int.TryParse(Console.ReadLine(), out int baseLength))
            {
                if (baseLength > 0)
                {
                    this.baseLength = baseLength;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
