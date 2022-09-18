namespace Task_1
{
    internal interface ISimpleNAngle : IGeometricFigure
    {
        double Heigth { get; }
        double Base { get; }
        double Angle { get; }
        double LengthSide { get; }
        int NumberOfSide { get; }
    }
}
