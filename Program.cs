using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.ReadLine();
            Task2();
            Console.ReadLine();
        }

        private static void Task2()
        {
            int createNumber = 5;
            int[] numbers = new int[createNumber];
            try
            {
                for (int i = 0; i <= numbers.Length; i++)
                {
                    numbers[i] = i;
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива");
            }
        }

        private static void Task1()
        {
            Console.WriteLine("z = x / y");
            Console.WriteLine("Введите числа 'x' и  'y'");
            double firstNumber;
            double.TryParse(Console.ReadLine(), out firstNumber);
            double secondNumber;
            double.TryParse(Console.ReadLine(), out secondNumber);
            Division(firstNumber, secondNumber);
        }

        private static void Division(double firstNumber, double secondNumber)
        {
            try
            {
                ExceptionArgumentException(firstNumber, secondNumber);
                ExceptionArgumentNullException(firstNumber);
                ExceptionArgumentNullException(secondNumber);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ExceptionArgumentException(double x, double y)//переменная равна нулю
        {
            if (x == 0 && y == 0)
            {
                throw new ArgumentException();
            }
        }

        private static void ExceptionArgumentNullException(double x)//переменная не задана
        {
            if (x == 0)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
