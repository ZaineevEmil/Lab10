using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Перевод угла в радианы
            Console.WriteLine("Программа перевода углов в радианы.\n\nВведите три параметра угла: градусы, минуты и секунды");
            Console.Write("в градусах - ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nв минутах - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nв секундах - ");
            int s = Convert.ToInt32(Console.ReadLine());
            CornerRadian cornerRadian = new CornerRadian();
            cornerRadian.Degree = c;
            cornerRadian.Minute = m;
            cornerRadian.Second = s;
            cornerRadian.Answer();
            Console.ReadKey();
        }
    }
    class CornerRadian
    {
        int degree;
        int minute;
        int second;
        public int Degree
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    degree = value;
                }
                else
                {
                    Console.WriteLine("Градусы - ведено недопустимое значение");
                }
            }
            get
            {
                return degree;
            }
        }
        public int Minute
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Минуты - введено недопустимое значение");
                }
            }
            get
            {
                return minute;
            }
        }
        public int Second
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("Секунды - введено недопустимое значение");
                }
            }
            get
            {
                return second;
            }
        }
        public CornerRadian(int degree = 0, int minute = 0, int second = 0)
        {
            int Degree = degree;
            int Minute = minute;
            int Second = second;
        }
        public void Answer()

        {
            double ToRadians = Degree * Math.PI / 180 + Minute * Math.PI / (180 * 60) + Second * Math.PI / (180 * 60 * 60);
            Console.WriteLine("\nЗначение угла в радианах - {0}", ToRadians);
        }
    }
}
