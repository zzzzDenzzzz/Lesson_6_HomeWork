using System;

namespace Task_1
{
    internal class Square : GeometricFigure
    {
        double sideLength;

        public Square(double sideLength)
        {
            if (sideLength > 0)
            {
                this.sideLength = sideLength;

                figurePerimeter = 4 * sideLength;
                figureArea = Math.Pow(sideLength, 2);
            }
            else
            {
                throw new ArgumentException("невозможно создать квадрат");
            }
        }

        public override string ToString()
        {
            return $"Периметр квадрата равен {figurePerimeter:F3}{Environment.NewLine}Площадь квадрата равна {figureArea:F3}";
        }
    }
}
