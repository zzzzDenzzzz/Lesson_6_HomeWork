using System;

namespace Task_2
{
    internal class Triangle : GeometricFigure, IFigure
    {
        int height;

        public Triangle() : base()
        {
            height = 5;
        }

        public static Triangle CreateTriangle()
        {
            return new Triangle();
        }

        public void Draw()
        {
            ConsoleFigure();
            Console.WriteLine();

            for (int i = height; i != 0; i--)
            {
                for (int j = i; j != 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(SYMBOL);
                for (int m = (height - i) * 2; m != 0; m--)
                {
                    Console.Write(SYMBOL);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void Size()
        {
            Console.WriteLine("Height triangle: ");
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
        }
    }
}
