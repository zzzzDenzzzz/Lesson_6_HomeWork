using System;

namespace Task_1
{
    internal class Rectangle : GeometricFigure, IGeometricFigure
    {
        double sideLengthAB;
        double sideLengthBC;
        const string exMessage = "невозможно создать прямоугольник";

        public double AB
        {
            get { return sideLengthAB; }
            private set
            {
                if (value > 0)
                {
                    sideLengthAB = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public double BC
        {
            get { return sideLengthBC; }
            private set
            {
                if (value > 0)
                {
                    sideLengthBC = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public Rectangle(double sideLengthAB, double sideLengthBC)
        {
            AB = sideLengthAB;
            BC = sideLengthBC;

            if (AB != BC)
            {
                figurePerimeter = Perimetr();
                figureArea = Area();
            }
            else
            {
                throw new ArgumentException(exMessage);
            }
        }

        public override string ToString()
        {
            return $"Периметр прямоугольника равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь прямоугольника равна {figureArea:F3}";
        }

        public double Perimetr()
        {
            return 2 * (AB + BC);
        }

        public double Area()
        {
            return AB * BC;
        }
    }
}
