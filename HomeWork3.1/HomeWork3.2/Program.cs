using System;

namespace HomeWork3._1
{
    // Суханов
    // а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    // Требуется подсчитать сумму всех нечётных положительных чисел.
    // Сами числа и сумму вывести на экран, используя tryParse.

    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            string a;
            int i;

            Console.WriteLine("Вводите числа, последним введите 0");
            do
            {
                a = Console.ReadLine();
                bool trully = Int32.TryParse(a, out i);
                while (trully == false)
                {
                    Console.WriteLine("Число ввести нужно...");
                    a = Console.ReadLine();
                    if (Int32.TryParse(a, out i)) break; // Ломал условие, чтобы можно было снова ернутся в прежний цикл
                }  

                if ((i > 0) && (i % 2 != 0))
                {
                    Sum = Sum + i;
                }
            } while (i != 0);

            Console.WriteLine($"Сумма положительных нечётных чисел {Sum}.");

        }
    }
}

