using System;

namespace Task_2
{
    internal class Rhomb : GeometricFigure, IFigure
    {
        int diagonal;

        public Rhomb() : base()
        {
            diagonal = 11;
        }

        public static Rhomb CreateRhomb()
        {
            return new Rhomb();
        }

        public void Draw()
        {
            ConsoleFigure();
            Console.WriteLine();

            int center = diagonal / 2;
            for (int i = 0; i < diagonal; i++)
            {
                for (int j = 0; j < diagonal; j++)
                {
                    if (i <= center)
                    {
                        // Верхняя половина ромба
                        if (j >= center - i && j <= center + i)
                            Console.Write(SYMBOL);
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        // Нижняя половина ромба
                        if (j >= center + i - diagonal + 1 && j <= center - i + diagonal - 1)
                            Console.Write(SYMBOL);
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void Size()
        {
            Console.WriteLine("Diagonal length rhomb: ");
            if (int.TryParse(Console.ReadLine(), out int diagonal))
            {
                if (diagonal % 2 == 0)
                {
                    diagonal++;
                }
                if (diagonal > 0)
                {
                    this.diagonal = diagonal;
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
