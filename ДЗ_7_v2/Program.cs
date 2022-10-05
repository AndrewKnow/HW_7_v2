using System;
using System.Diagnostics;

namespace ДЗ_7_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите номера элемента:");
            NumberEnteru(Console.ReadLine());
        }

        static void NumberEnteru(string n)
        { 
            int[] nums = new int[3] { 5, 10, 20 };

            var stopwatch = new Stopwatch();
            TimeSpan fTime;
            bool doWhile = false;
            // выход из метода если введено не чсило
            do
            {
                bool keyBoll = int.TryParse(n, out _);
                if (keyBoll)
                {

                    // 1 задание
                    Console.WriteLine("\nРекурсивный метод:");
                    Console.WriteLine("------------------------------------------------");
                    stopwatch.Start();
                    Console.Write($"Ответ для {n}: {FindNrecursive(int.Parse(n))}");
                    stopwatch.Stop();
                    fTime = stopwatch.Elapsed;
                    stopwatch.Reset();
                    Console.Write($", время: {fTime}");
                    Console.WriteLine();

                    // 3.1
                    for (int i = 0; i<nums.Length; i++)
                    {
                        stopwatch.Start();
                        Console.WriteLine();
                        Console.Write($"Ответ для {nums[i]}: {FindNrecursive(nums[i])}");
                        stopwatch.Stop();
                        fTime = stopwatch.Elapsed;
                        stopwatch.Reset();
                        Console.Write($", время: {fTime}");
                    }


                    // 2 задание
                    Console.WriteLine("\n\nИтеративный метод:");
                    Console.WriteLine("------------------------------------------------");
                    stopwatch.Start();
                    Console.Write($"Ответ для {n}: {FindNiterative(int.Parse(n))}");
                    stopwatch.Stop();
                    fTime = stopwatch.Elapsed;
                    stopwatch.Reset();
                    Console.Write($", время: {fTime}");

                    Console.WriteLine();

                    // 3.2

                    for (int i = 0; i<nums.Length; i++)
                    {
                        stopwatch.Start();
                        Console.WriteLine();
                        Console.Write($"Ответ для {nums[i]}: {FindNiterative(nums[i])}");
                        stopwatch.Stop();
                        fTime = stopwatch.Elapsed;
                        stopwatch.Reset();
                        Console.Write($", время: {fTime}");
                    }
                    doWhile = true;
                }
                else
                {
                    Console.WriteLine("Ввидите номера элемента:");
                    NumberEnteru(Console.ReadLine());
                }
            }
            while (doWhile == false) ;

        }

        static int FindNrecursive(int fibN)
        {
            if (fibN == 0 || fibN == 1) return fibN;
            // задано fibN >= 2

            int result = Fib(fibN);

            static int Fib(int n)
            {
                if (n == 0 || n == 1) return n;
                return Fib(n - 1) + Fib(n - 2);
            }

            return result;
        }


        static int FindNiterative(int fibN)
        {
            if (fibN == 0 || fibN == 1) return fibN;
            // задано fibN >= 2

            int f1 = 1;
            int f2 = 0;
            int fVar;
            for (int i = 2; i < fibN; i++)
            {
                fVar = f1;
                f1 += f2;
                f2 = fVar;
            }

            int result = f1 + f2;

            return result;
        }
    }
}
