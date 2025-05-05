using Math_practice1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Math_practice1
{
    internal class Program
    {
        static Tasks tasks = new Tasks();
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнил Панфилов А.Д. П23-2.1");
            while (true)
            {
                Console.WriteLine("Введите номер задания: ");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        tasks.Task1();
                        break;
                    case 2:
                        tasks.Task2();
                        break;
                    case 3:
                        tasks.Task3();
                        break;
                    case 4:
                        tasks.Task4();
                        break;
                    case 5:
                        tasks.Task5();
                        break;
                    case 6:
                        tasks.Task6();
                        break;
                    case 7:
                        tasks.Task7();
                        break;
                    case 8:
                        tasks.Task8();
                        break;
                    case 9:
                        tasks.Task9();
                        break;
                    case 10:
                        tasks.Task10();
                        break;
                    case 11:
                        tasks.Task11();
                        break;
                    case 12:
                        tasks.Task12();
                        break;
                    case 13:
                        tasks.Task13();
                        break;
                    case 14:
                        tasks.Task14();
                        break;
                    case 15:
                        tasks.Task15();
                        break;
                    case 16:
                        tasks.Task16();
                        break;
                    case 17:
                        tasks.Task17();
                        break;
                    case 18:
                        tasks.Task18();
                        break;
                    case 19:
                        tasks.Task19();
                        break;
                    case 20:
                        tasks.Task20();
                        break;
                    case 21:
                        tasks.Task21();
                        break;
                    case 22:
                        tasks.Task22();
                        break;
                    case 23:
                        tasks.Task23();
                        break;
                    case 24:
                        tasks.Task24();
                        break;
                    case 25:
                        tasks.Task25();
                        break;
                    case 26:
                        tasks.Task26();
                        break;
                    case 27:
                        tasks.Task27();
                        break;
                    case 28:
                        tasks.Task28();
                        break;
                    case 29:
                        tasks.Task29();
                        break;
                    case 30:
                        tasks.Task30();
                        break;

                    default:
                        Console.WriteLine("Напиши номер правильно обмудень.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
