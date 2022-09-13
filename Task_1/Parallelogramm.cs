using System;

namespace Task_1
{
    internal class Parallelogramm : GeometricFigure
    {
        double sideLengthAB;
        double sideLengthBC;
        double angleInRadians;

        public Parallelogramm(double sideLengthAB, double sideLengthBC, double angle)
        {
            if (sideLengthAB > 0 && sideLengthBC > 0 && sideLengthAB != sideLengthBC && angle > 0 && angle < 90)
            {
                this.sideLengthAB = sideLengthAB;
                this.sideLengthBC = sideLengthBC;
                angleInRadians = Math.PI * angle / 180;

                figurePerimeter = 2 * (sideLengthAB + sideLengthBC);
                figureArea = sideLengthAB * sideLengthBC * Math.Sin(angleInRadians);
            }
            else
            {
                throw new ArgumentException("невозможно создать параллелограмм");
            }
        }

        public override string ToString()
        {
            return $"Периметр параллелограмма равен {figurePerimeter:F3}{Environment.NewLine}Площадь параллелограмма равна {figureArea:F3}";
        }
    }
}
