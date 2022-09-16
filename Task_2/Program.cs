using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2 . Написать приложение, которое будет отображать в консоли простейшие геометрические фигуры заданные 
пользователем . Пользователь выбирает фигуру и задает ее расположение на экране, а также размер и цвет с помощью 
меню . Все заданные пользователем фигуры отображаются одновременно на экране . Фигуры (прямоугольник, 
ромб, треугольник, трапеция, многоугольник) рисуются звездочками или другими символами . Для реализации 
программы необходимо разработать иерархию классов (продумать возможность абстрагирования) .
Для хранения всех, заданных пользователем фигур, создать класс «Коллекция геометрических фигур» с ме-
тодом «Отобразить все фигуры» . Чтобы отобразить все фигуры указанным методом требуется использовать 
оператор foreach, для чего в классе «Коллекция геометрических фигур» необходимо реализовать соответствующие интерфейсы .*/

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.Size();
            t.Color();
            t.CursorPosition();
            //t.Draw();

            var tr = new Trapezoid();
            tr.Size();
            tr.Color();
            tr.CursorPosition();
            //tr.Draw();

            var r = new Rhomb();
            r.Size();
            r.Color();
            r.CursorPosition();
            //r.Draw();

            var rt = new Rectangle();
            rt.Size();
            rt.Color();
            rt.CursorPosition();
            //rt.Draw();

            var fc = new FigureCollection(t, tr, r, rt);
            fc.PrintAll();

            var fc1 = new FigureCollection(Trapezoid.CreateTrapezoid(), Rectangle.CreateRectangle(),
                Rhomb.CreateRhomb(), Trapezoid.CreateTrapezoid(), Triangle.CreateTriangle());
            fc1.PrintAll();
        }
    }
}
