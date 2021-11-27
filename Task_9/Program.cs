using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine();
            bool er;
            int a = 0;
            int b = 0;
            byte oper = 0;
            do
            {
                try
                {
                    Console.Write("Введите целое число, a = ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    er = false;
                    a = a1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    er = true;
                }
            }
            while (er != false);

            do
            {
                try
                {
                    Console.Write("Введите целое число, b = ");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    er = false;
                    b = b1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    er = true;
                }
            }
            while (er != false);
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - произведение");
            Console.WriteLine("4 - частное");

            do
            {
                try
                {
                    Console.Write("Ваш выбор: ");
                    Byte operation = Convert.ToByte(Console.ReadLine());
                    er = false;
                    oper = operation;
                    if (operation > 4 || operation < 1)
                    {
                        Console.WriteLine("Ошибка! Введите код операции в диапазоне от 1 до 4");
                        er = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    er = true;
                }
            }
            while (er != false);

            switch (oper)
            {
                case 1:
                    Summation(a, b);
                    break;
                case 2:
                    Subtraction(a, b);
                    break;
                case 3:
                    Multiplication(a, b);
                    break;
                case 4:
                    Dividing(a, b);
                    break;
            }
            Console.ReadKey();
        }
        static void Summation(int a, int b)
        {
            long a1 = a;
            long b1 = b;
            long result = a1 + b1;
            Console.WriteLine("Результат операции: {0}", result);
        }
        static void Subtraction(int a, int b)
        {
            long a1 = a;
            long b1 = b;
            long result = a1 - b1;
            Console.WriteLine("Результат операции: {0}", result);
        }

        static void Multiplication(int a, int b)
        {
            try
            {
                long a1 = a;
                long b1 = b;
                long result = a1 * b1;
                Console.WriteLine("Результат операции: {0}", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Dividing(int a, int b)
        {
            try
            {
                int r = a / b;
                double a1 = a;
                double b1 = b;
                double result = Math.Round (a1 / b1, 2);
                Console.WriteLine("Результат операции: {0}", result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! Деление на 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
