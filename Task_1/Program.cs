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
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            Console.WriteLine();

            try
            {
                var square = new Square(10.35);
                Console.WriteLine(square);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            Console.WriteLine();

            try
            {
                var rhomb = new Rhomb(5.5, 30);
                Console.WriteLine(rhomb);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            Console.WriteLine();

            try
            {
                var rectangle = new Rectangle(15.49, 12.53);
                Console.WriteLine(rectangle);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            Console.WriteLine();

            try
            {
                var parallelogramm = new Parallelogramm(15, 12.53, 45);
                Console.WriteLine(parallelogramm);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            Console.WriteLine();
        }
    }
}
