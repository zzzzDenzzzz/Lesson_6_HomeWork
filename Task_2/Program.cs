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
            //Triangle triangle = new Triangle();
            //triangle.CursorPosition(5, 5);
            //triangle.Color(12);
            //triangle.Draw();

            //int trapezoidTopBaseLength = 0,
            //trapezoidHeight = 0;

            //Console.WriteLine("Задайте параметры для построения равнобедренной трапеции:");
            //Console.Write("Введите длину верхнего основания (b > 1): ");
            //trapezoidTopBaseLength = Int32.Parse(Console.ReadLine());
            //while (trapezoidTopBaseLength < 2)
            //{
            //    Console.WriteLine("Ошибка: значение верхнего основания должно быть больше 1!");
            //    Console.Write("Повторите ввод: ");
            //    trapezoidTopBaseLength = Int32.Parse(Console.ReadLine());
            //}

            //Console.Write("Введите высоту (h > 1): ");
            //trapezoidHeight = Int32.Parse(Console.ReadLine());
            //while (trapezoidHeight < 2)
            //{
            //    Console.WriteLine("Ошибка: значение высоты должно быть больше 1!");
            //    Console.Write("Повторите ввод: ");
            //    trapezoidHeight = Int32.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Равнобедренная трапеция с заданными параметрами:");
            //for (int i = 0; i < trapezoidHeight; i++)
            //    Console.WriteLine($"{new string(' ', trapezoidHeight - i - 1)}{new string('*', trapezoidTopBaseLength + 2 * i)}");

            int i, j, N = 21;
            int center = N / 2;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i <= center)
                    {
                        // Верхняя половина ромба
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        // Нижняя половина ромба
                        if (j >= center + i - N + 1 && j <= center - i + N - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
