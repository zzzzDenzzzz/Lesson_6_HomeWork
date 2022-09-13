using System;

namespace Task_1
{
    internal class Ellipse : GeometricFigure, IGeometricFigure
    {
        double bigSemiAxisLength;
        double smallSemiAxisLength;
        const string exMessage = "невозможно создать эллипс";

        public double BigSemiAxis
        {
            get { return bigSemiAxisLength; }
            private set
            {
                if (value > 0)
                {
                    bigSemiAxisLength = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public double SmallSemiAxis
        {
            get { return smallSemiAxisLength; }
            private set
            {
                if (value > 0)
                {
                    smallSemiAxisLength = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public Ellipse(double bigSemiAxisLength, double smallSemiAxisLength)
        {
            BigSemiAxis = (bigSemiAxisLength > smallSemiAxisLength) ? bigSemiAxisLength : smallSemiAxisLength;
            SmallSemiAxis = (smallSemiAxisLength < bigSemiAxisLength) ? smallSemiAxisLength : bigSemiAxisLength;

            if (BigSemiAxis != SmallSemiAxis)
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
            return $"Периметр эллипса равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь эллипса равна {figureArea:F3}";
        }

        public double Area()
        {
            return Math.PI * BigSemiAxis * SmallSemiAxis;
        }

        public double Perimetr()
        {
            return 4 * (Math.PI * BigSemiAxis * SmallSemiAxis + (BigSemiAxis - SmallSemiAxis)) / (BigSemiAxis + SmallSemiAxis);
        }
    }
}
