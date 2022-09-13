using System;

namespace Task_1
{
    internal class Square : GeometricFigure, IGeometricFigure
    {
        double sideLength;
        const string exMessage = "невозможно создать квадрат";

        public double Side
        {
            get { return sideLength; }
            private set
            {
                if (value > 0)
                {
                    sideLength = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public Square(double sideLength)
        {
            Side = sideLength;

            figurePerimeter = Perimetr();
            figureArea = Area();
        }

        public override string ToString()
        {
            return $"Периметр квадрата равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь квадрата равна {figureArea:F3}";
        }

        public double Perimetr()
        {
            return 4 * Side;
        }

        public double Area()
        {
            return Math.Pow(Side, 2);
        }
    }
}
