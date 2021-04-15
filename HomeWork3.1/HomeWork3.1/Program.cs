using System;

namespace HomeWork3._1a
{
    // Суханов
    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

    public struct Complex
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
            } else
            if (this.im < 0) Console.WriteLine($"{this.re} - {-this.im}i");
            else if (this.im == 0) Console.WriteLine($"{this.re}"); 
            else Console.WriteLine($"{this.re} + {this.im}i");
        }

        public static Complex Razn(Complex z, Complex y)
        {
            Complex result = new Complex(
                re: z.re - y.re,
                im: z.im - y.im
                );
            return result;
        }
    }
    class Program
    {
        // Вывод комплексных чисел, а также их расхности. Сама демонстрация. 
        static void Main(string[] args)
        {
            Complex a = new Complex(2, 1);
            Complex b = new Complex(2, 4);  // Создаются сразу 2 комплексных числа. 
            Complex c = Complex.Razn(a, b); // Далее вычисляется их разница. 
            a.Print();                      
            b.Print();
            c.Print();                      // Наконец числа выводятся на экран, а именно первое, второе число и их разность. 
        }
    }


}
