using System;

namespace HomeWork3._1bc
{
    // Суханов
    // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

    public class Complex
    {
        public int re;
        public int im;

        public Complex(int re, int im)
        {
            this.re = re;
            this.im = im;
        }

        public void Print()
        {
            if (this.re == 0)
            {
                if (this.im < 0) Console.WriteLine($"-{-this.im}i");
                else if (this.im == 0) Console.WriteLine($"{this.im}");
                else Console.WriteLine($"{this.im}i");
            }
            else
            if (this.im < 0) Console.WriteLine($"{this.re} - {-this.im}i");
            else if (this.im == 0) Console.WriteLine($"{this.re}");
            else Console.WriteLine($"{this.re} + {this.im}i");
        }

        public static Complex Razn(Complex z, Complex y) // Вычисление разности комплексных чисел 
        {
            Complex result = new Complex(
                re: z.re - y.re,
                im: z.im - y.im
                );
            return result;
        }

        public static Complex Proiz(Complex z, Complex y) // Вычисление произведения комплексных чисел 
        {
            Complex result = new Complex(
                re: z.re * y.re - z.im * y.im,
                im: y.re * z.im + z.re * y.im
            );
            return result;
        }
    }
    class Program
    {
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.

        static void Main(string[] args)
        {
            // Сделал так, чтобы пользователь сам вводил комплексные числа

            Console.Write("Введите реальную часть первого комплексного числа: "); 
            int re = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите мнимую часть первого комплексного числа: ");
            int im = Convert.ToInt32(Console.ReadLine());

            Complex first = new Complex(re, im);

            Console.Write("Введите реальную часть второго комплексного числа: ");
            re = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите мнимую часть второго комплексного числа: ");
            im = Convert.ToInt32(Console.ReadLine());

            Complex second = new Complex(re, im);

            first.Print();  // Вывел сами числа для пользователя,
            second.Print(); // которые он ввёл


            Console.Write("Какое действие делаем с этими числами: умножение или вычитание? "); // Тут же дал выбор пользователю,
            string choice = Console.ReadLine();                                                // какое действие произвести с числами
            switch (choice)
            {
                case "Вычитание":
                case "вычитание":
                    Complex res = Complex.Razn(first, second);
                    res.Print();
                    break;
                case "Умножение":
                case "умножение":
                    res = Complex.Proiz(first, second);
                    res.Print();
                    break;
                default:
                    Console.Write("Не умею так делать.");
                    break;
            }




        }
    }


}
