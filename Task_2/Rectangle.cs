using System;

namespace Task_2
{
    internal class Rectangle : GeometricFigure, IFigure
    {
        int height;
        int length;

        public Rectangle() : base()
        {
            height = 5;
            length = 10;
        }

        public void Draw()
        {
            ConsoleFigure();
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(SYMBOL);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void Size()
        {
            Console.WriteLine("Height rectangle: ");
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

            Console.WriteLine("Length rectangle: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                if (length > 0)
                {
                    this.length = length;
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

            if (height == length)
            {
                throw new ArgumentException();
            }
        }
    }
}
