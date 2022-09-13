using System;

namespace Task_1
{
    internal class Rectangle : GeometricFigure
    {
        double sideLengthAB;
        double sideLengthBC;

        public Rectangle(double sideLengthAB, double sideLengthBC)
        {
            if (sideLengthAB > 0 && sideLengthBC > 0 && sideLengthAB != sideLengthBC)
            {
                this.sideLengthAB = sideLengthAB;
                this.sideLengthBC = sideLengthBC;

                figurePerimeter = 2 * (sideLengthAB + sideLengthBC);
                figureArea = sideLengthAB * sideLengthBC;
            }
            else
            {
                throw new ArgumentException("невозможно создать прямоугольник");
            }
        }

        public override string ToString()
        {
            return $"Периметр прямоугольника равен {figurePerimeter:F3}{Environment.NewLine}Площадь прямоугольника равна {figureArea:F3}";
        }
    }
}
