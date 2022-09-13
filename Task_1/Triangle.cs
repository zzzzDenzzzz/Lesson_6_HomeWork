using System;

namespace Task_1
{
    internal class Triangle : GeometricFigure
    {
        double sideLengthAB;
        double sideLengthBC;
        double sideLengthAC;

        public Triangle(double sideLengthAB, double sideLengthBC, double sideLengthAC)
        {
            if (sideLengthAB + sideLengthAC > sideLengthBC &&
                sideLengthAB + sideLengthBC > sideLengthAC &&
                sideLengthAC + sideLengthBC > sideLengthAB)
            {
                this.sideLengthAB = sideLengthAB;
                this.sideLengthBC = sideLengthBC;
                this.sideLengthAC = sideLengthAC;

                double halfPerimeter = (sideLengthAB + sideLengthAC + sideLengthBC) / 2;
                figurePerimeter = sideLengthAB + sideLengthBC + sideLengthAC;
                figureArea = Math.Sqrt(halfPerimeter * (halfPerimeter - sideLengthAB) * (halfPerimeter - sideLengthAC) * (halfPerimeter - sideLengthBC));
            }
            else
            {
                throw new ArgumentException("невозможно создать треугольник");
            }
        }

        public override string ToString()
        {
            return $"Периметр треугольника равен {figurePerimeter:F3}{Environment.NewLine}Площадь треугольника равна {figureArea:F3}";
        }
    }
}
