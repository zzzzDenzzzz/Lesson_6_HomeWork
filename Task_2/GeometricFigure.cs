using System;

namespace Task_2
{
    internal abstract class GeometricFigure
    {
        protected const char SYMBOL = '@';
        protected int colorFigure;
        protected int cursorPositionLeft;
        protected int cursorPositionTop;

        protected GeometricFigure()
        {
            colorFigure = 3;
            cursorPositionLeft = 10;
            cursorPositionTop = 10;
        }

        protected void ConsoleFigure()
        {
            Console.SetCursorPosition(cursorPositionLeft, cursorPositionTop);
            Console.ForegroundColor = (ConsoleColor)colorFigure;
        }

        public void Color()
        {
            Console.WriteLine("Color 1-12: ");
            if (int.TryParse(Console.ReadLine(), out int color))
            {
                if (color > 0 && color < 12)
                {
                    colorFigure = color;
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

        public void CursorPosition()
        {
            Console.WriteLine("Cursor position left: ");
            if (int.TryParse(Console.ReadLine(), out int left))
            {
                cursorPositionLeft = left;
            }
            else
            {
                throw new ArgumentException();
            }

            Console.WriteLine("Cursor position top: ");
            if (int.TryParse(Console.ReadLine(), out int top))
            {
                cursorPositionTop = top;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
