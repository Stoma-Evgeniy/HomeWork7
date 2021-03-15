using System;
using System.Collections.Generic;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 23, 7, 324, 46 };

            Console.WriteLine("Содержимое колекции: ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]+ " ");
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] % 10;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Содержимое колекции: ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            List<int> lst = new List<int>() { 1, 2, 1, 4, 2, 5, 6, 3, 3, 1 };


            for (int j = 1; j < 7; j++)
            {
                int count = 0;
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] == j)
                    {
                        count++;
                    }
                }
                Console.Write(j + " - " + count + "шт ");
            }
                
            
            

        }
    }
}
