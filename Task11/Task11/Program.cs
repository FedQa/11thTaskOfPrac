using System;

namespace Task11
{
    class Program
    {
        static void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static void Create(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        { 
            //шифровка
            Console.WriteLine("N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            b[1] = a[1];
            Console.WriteLine("Изначальная последовательность:");
            Create(a);
            for (int i = 2; i < N; i++)
            {
                if (a[i] == a[i - 1]) b[i] = 1;
                else b[i] = 0;
            }
            Console.WriteLine("Шифрованная последовательность:");
            Print(b);
        }
    }
}
