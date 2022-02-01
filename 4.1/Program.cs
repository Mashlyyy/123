using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дано целое число K и набор ненулевых целых чисел. Вывести номер последнего числа в наборе, большего K. Если таких чисел нет,
            //то вывести 0.
            Console.WriteLine("Введите целое число К");
            int K = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[K];
            Random rnd = new Random();
            int n=0;
            for (int i = 0; i < n-1; i--)
            {
                mas[i] = rnd.Next(-10, 11);
                Console.WriteLine(mas[i]);
 
            }
            Console.WriteLine();
            Console.WriteLine("mas2");
            for (int i = 0; i < n-1; i--)
            {
                if (mas[i] > K)
                {
                    Console.WriteLine("Номер последнего числа, большего ",  + K, "=", +i);
                } 
                if (mas[i] < K)
                    Console.WriteLine("0");
            }

            }
        }
        }
    

