using ConsoleApp29.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание (1-14): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Задание №1");
                        Task1[] points = {
                            new Task1(3.5, 7.2),
                            new Task1(-0.5, 1.2),
                            new Task1(0.72, -3.12)
                        };

                        foreach (var point in points)
                        {
                            point.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Задание №2");
                        Task2[] numbers = {
                            new Task2(3, 3.5, -2.1),
                            new Task2(2.1, -6.55, 0.1),
                            new Task2(-9, -3.7, -0.1)
                        };

                        foreach (var num in numbers)
                        {
                            num.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Задание №3");
                        Task3[] circles = {
                            new Task3(2, 1.5, 2.5),
                            new Task3(-0.5, 2.3, 2.5),
                            new Task3(1.5, -0.8, 2.5)
                        };

                        foreach (var circle in circles)
                        {
                            circle.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Задание №4");
                        Task4[] triangles = {
                            new Task4(3, 4, 5),
                            new Task4(5, 12, 13),
                            new Task4(8, 15, 17)
                        };

                        foreach (var triangle in triangles)
                        {
                            triangle.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Задание №5");
                        Task5[] months = {
                            new Task5(3),
                            new Task5(6),
                            new Task5(9),
                            new Task5(12)
                        };

                        foreach (var month in months)
                        {
                            month.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Задание №6");
                        Task6[] values = {
                            new Task6(-3, 3.5, 0.1),
                            new Task6(58, 27, -87),
                            new Task6(-8, -35, 42)
                        };

                        foreach (var value in values)
                        {
                            value.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Задание №7");
                        Task7[] points7 = {
                            new Task7(2, 2, 4, 0),
                            new Task7(8, 9, 12, 1),
                            new Task7(-3.5, 0.9, 2, 3)
                        };

                        foreach (var point in points7)
                        {
                            point.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Задание №8");
                        Task8[] triangles8 = {
                            new Task8(3, 3.5, 1.1),
                            new Task8(3, 6.55, 6.55),
                            new Task8(0.9, 0.9, 0.9)
                        };

                        foreach (var triangle in triangles8)
                        {
                            triangle.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Задание №9");
                        Task9[] operators = {
                            new Task9(0.50, 0.10, 100, 50),
                            new Task9(0.45, 0.08, 100, 50),
                            new Task9(0.55, 0.12, 100, 50)
                        };

                        foreach (var op in operators)
                        {
                            op.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Задание №10");
                        Task10[] cards = {
                            new Task10(1, 'c'),
                            new Task10(2, 'a'),
                            new Task10(3, 'b')
                        };

                        foreach (var card in cards)
                        {
                            card.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Задание №11");
                        Task11[] pairs = {
                            new Task11(-3, 3.5),
                            new Task11(5.8, 2.7),
                            new Task11(-8, -3.5)
                        };

                        foreach (var pair in pairs)
                        {
                            pair.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Задание №12");
                        Task12[] numbers12 = {
                            new Task12(45, 13, -23),
                            new Task12(-31, 65, 12),
                            new Task12(52, -1, -33)
                        };

                        foreach (var num in numbers12)
                        {
                            num.Calculate();
                        }
                        Console.ReadKey();
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine("Задание №13");
                        Task13[] numbers13 = {
                            new Task13(3.2, -7, 0.5),
                            new Task13(2.3, 3, 2.5),
                            new Task13(23, -34, 89.5)
                        };

                        foreach (var num in numbers13)
                        {
                            num.Calculate();
                        }
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}