using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace оценки
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool exit = true;
            double[] numbers = new double[0];
            double[] numbers1 = new double[0];
            while (exit)
            {
                Console.WriteLine("Введите оценку,расчет,exit");
                switch (input = Console.ReadLine())
                {
                    case "exit":
                        exit = false;
                        break;

                    case "расчет":
                        double arraySum = 0;

                        for (int i = 0; i < numbers1.Length; i++)
                        {
                            arraySum += numbers1[i];
                        }


                        double arraySum2 = 0;

                        for (int i = 0; i < numbers1.Length; i++)
                        {
                            arraySum2 += numbers1[i] * numbers[i];
                        }

                        double marcs = arraySum2 / arraySum;

                        Console.WriteLine($"Оценка: {marcs} ");
                        break;

                    default:
                        double[] numbersCopy = new double[numbers.Length + 1];
                        double number = Convert.ToDouble(input);

                        for (int i = 0; numbers.Length > i; i++)
                        {
                            numbersCopy[i] = numbers[i];
                        }

                        numbersCopy[numbersCopy.Length - 1] = number;
                        numbers = numbersCopy;

                        
                        Console.WriteLine("В ведите бал оценки");
                        double input2 = Convert.ToDouble(Console.ReadLine());

                        double[] numbersCopy2 = new double[numbers1.Length + 1];
                        double number2 = Convert.ToDouble(input2);

                        for (int i = 0; numbers1.Length > i; i++)
                        {
                            numbersCopy2[i] = numbers1[i];
                        }

                        numbersCopy2[numbersCopy2.Length - 1] = number2;
                        numbers1 = numbersCopy2;
                        break;

                }
            }
        }
    }
}
