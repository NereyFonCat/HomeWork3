using System;

namespace HomeWork3._3
{
    // Суханов
    // *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    // Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    // Написать программу, демонстрирующую все разработанные элементы класса.

    public class Drob // Описание класса дробей
    {
        public int chisl;
        public int znam;

        public Drob(int chisl,int znam)
        {
            this.chisl = chisl;
            this.znam = znam;
        }

        public static Drob Sum(Drob a, Drob b) // Сумма дробей
        {
            Drob result;
            if (a.znam == b.znam)
            {
                result = new Drob(
                chisl: a.chisl + b.chisl,
                znam: a.znam);
                return result;
            } else
            {
                result = new Drob(
                    chisl: a.chisl * b.znam + b.chisl * a.znam,
                    znam: a.znam * b.znam);
            } return result;
        }
        public static Drob Razn(Drob a, Drob b) // Разность дробей
        {
            Drob result;
            if (a.znam == b.znam)
            {
                result = new Drob(
                chisl: a.chisl - b.chisl,
                znam: a.znam);
            }
            else
            {
                result = new Drob(
                    chisl: a.chisl * b.znam - b.chisl * a.znam,
                    znam: a.znam * b.znam);
            }
            return result;
        }
        public static Drob Proiz(Drob a, Drob b) // Произведение дробей
        {
            Drob result = new Drob(
            chisl: a.chisl * b.chisl,
            znam: a.znam * b.znam);
            return result;
        }
        public static Drob Del(Drob a, Drob b) // Деление дробей
        {
            Drob result = new Drob(
            chisl: a.chisl * b.znam,
            znam: a.znam * b.chisl);
            return result;
        }
        public void Print() // Вывод обыкновенной дроби
        {
            Console.WriteLine($"{this.chisl}/{this.znam}");
        }

        // Добавить свойства типа int для доступа к числителю и знаменателю
        public int ch // Свойство, которое возвращает числитель типа int
        {
            get
            {
                return this.chisl;
            }
            set
            {
                ch = this.chisl;
            }
        }
        public int zn // Свойство, которое возвращает знаменатель типа int
        {
            get
            {
                return this.znam;
            }
            set
            {
                ch = this.znam;
            }
        }
        // Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        public double dr // Свойство для получения дроби в десятичной форме
        {
            get
            {
                return (double) chisl / znam;
            }
        }
        public static Drob Easy(Drob a)          // *** Добавить упрощение дробей.
        {
            while ((a.chisl % 2 == 0) && (a.znam % 2 == 0))
            {
                a.chisl = a.chisl / 2;
                a.znam = a.znam / 2;
            }
            while ((a.chisl % 3 == 0) && (a.znam % 3 == 0))
            {
                a.chisl = a.chisl / 3;
                a.znam = a.znam / 3;
            }
            while ((a.chisl % 5 == 0) && (a.znam % 5 == 0))
            {
                a.chisl = a.chisl / 5;
                a.znam = a.znam / 5;
            }
            while ((a.chisl % 7 == 0) && (a.znam % 7 == 0))
            {
                a.chisl = a.chisl / 7;
                a.znam = a.znam / 7;
            }
            Drob result = new Drob(
                chisl: a.chisl,
                znam: a.znam);
            return result;
        }
    }
    class Program
    {            
        static void Main(string[] args)
        {
            int ch;
            int zn;
            Console.Write("Введите числитель первой дроби: ");
            ch = Int32.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель первой дроби: ");

            zn = Int32.Parse(Console.ReadLine()); 

            if (zn == 0)   // ** Добавить проверку, чтобы знаменатель не равнялся 0.
                           // Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            {
                do
                {
                    ArgumentException("Знаменатель не может быть равен 0");
                    Console.Write("Введите знаменатель первой дроби: ");
                    zn = Int32.Parse(Console.ReadLine());
                } while (zn == 0);   
            }
            Drob first = new Drob(ch, zn); // Первая дроб от пользователя 

            Console.Write("Введите числитель второй дроби: ");
            ch = Int32.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель второй дроби: ");
            zn = Int32.Parse(Console.ReadLine());

            if (zn == 0)   // ** Добавить проверку, чтобы знаменатель не равнялся 0.
                           // Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            {
                do
                {
                    ArgumentException("Знаменатель не может быть равен 0");
                    Console.Write("Введите знаменатель второй дроби: ");
                    zn = Int32.Parse(Console.ReadLine());
                } while (zn == 0);
            }

            Drob second = new Drob(ch, zn); // Вторая дроб от пользователя

            first.Print();
            second.Print();

            Drob s = Drob.Sum(first, second);
            Console.Write($"Сумма дробей: ");
            s.Print();

            Drob r = Drob.Razn(first, second);
            Console.Write($"Разность дробей: ");
            r.Print();

            Drob p = Drob.Proiz(first, second);
            Console.Write($"Произведение дробей: ");
            p.Print();

            Drob d = Drob.Del(first, second);
            Console.Write($"Частное дробей: ");
            d.Print();

            Console.WriteLine($"Числитель в сумме дробей {s.ch}, а знаменатель {s.zn}."); // Не знаю, правильно ли понял задание, что требовалось

            Console.WriteLine($"Десятичная дробь разности обыкновенных дробей {r.dr:f3}.");

            s = Drob.Easy(s);
            r = Drob.Easy(r);
            p = Drob.Easy(p);
            d = Drob.Easy(d);

            Console.WriteLine($"Упрощённые дроби:");

            Console.Write($"Сумма: ");
            s.Print();
            Console.Write($"Разность: ");
            r.Print();
            Console.Write($"Произведение: ");
            p.Print();
            Console.Write($"Частное: ");
            d.Print();
        }

        private static void ArgumentException(string v) // Не знаю, правильно ли применил и сделал исключение нуля...
        {
            Console.WriteLine("Знаменатель не может быть равен 0");
        }
    }
}
