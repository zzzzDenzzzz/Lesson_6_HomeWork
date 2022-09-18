using System;

/*1 . Разработать абстрактный класс ГеометрическаяФигура с полями ПлощадьФигуры и ПериметрФигуры .
Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм, Трапеция, 
Круг, Эллипс и реализовать свойства, которые однозначно определяют объекты данных классов .
Реализовать интерфейс ПростойНУгольник, который имеет свойства: Высота, Основание, УголМеждуОснова-
ниемИСмежнойСтороной, КоличествоСторон, ДлиныСторон, Площадь, Периметр .
Реализовать класс СоставнаяФигура который может состоять из любого количества ПростыхНУгольников . 
Для данного класса определить метод нахождения площади фигуры .
Предусмотреть варианты невозможности задания фигуры (введены отрицательные длины сторон или при 
создании объекта треугольника существует пара сторон, сумма длин которых меньше длины третьей стороны и т .п .)*/

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var triangle = new Triangle(3, 3, 2);
                Console.WriteLine(triangle);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Высота треугольника равна {triangle.Heigth:f3}");
                Console.WriteLine($"Основание AC треугольника {triangle.Base:f3}");
                Console.WriteLine($"Угол между AB и AC равен {triangle.Angle:f3}");
                Console.WriteLine($"Количествр сторон в треугольнике {triangle.NumberOfSide}");
                Console.ResetColor();
                Console.WriteLine();

                var square = new Square(10.35);
                Console.WriteLine(square);
                Console.WriteLine();

                var rhomb = new Rhomb(5.5, 30);
                Console.WriteLine(rhomb);
                Console.WriteLine();

                var rectangle = new Rectangle(15.49, 10.49);
                Console.WriteLine(rectangle);
                Console.WriteLine();

                var parallelogramm = new Parallelogramm(15, 12.53, 45);
                Console.WriteLine(parallelogramm);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Высота параллелограмма равна {parallelogramm.Heigth:f3}");
                Console.WriteLine($"Основание BC параллелограмма {parallelogramm.Base:f3}");
                Console.WriteLine($"Угол между AB и BC равен {parallelogramm.Angle:f3}");
                Console.WriteLine($"Количествр сторон в параллелограмме {parallelogramm.NumberOfSide}");
                Console.ResetColor();
                Console.WriteLine();

                var circle = new Circle(3.14);
                Console.WriteLine(circle);
                Console.WriteLine();

                var ellipse = new Ellipse(2.5, 3.14);
                Console.WriteLine(ellipse);
                Console.WriteLine();

                var compaundFigure = new CompoundFigure(triangle, square, rhomb, rectangle, parallelogramm, circle, ellipse);
                compaundFigure.PrintAreaCompaundFigure();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}
