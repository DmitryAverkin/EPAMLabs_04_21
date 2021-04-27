using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите размер массива:");
            x = int.Parse(Console.ReadLine());
            int[] ar = new int[x];
            for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("Введите индекс массива [{0}] ", i);
                    ar[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Элементы массива:");
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("ar[{0}] = {1}", i, ar[i]);
                }

                Console.WriteLine("Отсортированный массив по возрастанию:");

                int a;
                for (int i = 0; i < x - 1; i++)
                {
                    for (int y = i + 1; y < x; y++)
                    {
                        if (ar[i] > ar[y])
                        {
                            a = ar[i];
                            ar[i] = ar[y];
                            ar[y] = a;
                        }
                    }
                }

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("ar[{0}] = {1}", i, ar[i]);
                }
        }     
    }
}
