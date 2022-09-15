using System;

namespace Task_2
{
    internal class Triangle : IFigure
    {
        int size;
        public void Color(int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
        }

        public void CursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        public void Draw()
        {
            for (int i = size; i != 0; i--)
            {
                for (int j = i; j != 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int m = (size - i) * 2; m != 0; m--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void Size()
        {
            size = int.Parse(Console.ReadLine());
        }
    }
}
