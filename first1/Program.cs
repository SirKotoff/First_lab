using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first1
{



    public class A
    {
        public int a = 0;
        public string b = "";
        public const int ten = 10;
        public const int two = 2;
        public int ost = 0;

        public void ConvByteSys()
        {
            //системное конвертирование десятичное значение целого числа пример число 56  5 в двоичной системе  = 101
            Console.WriteLine("Введите число [например 30]:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
               
                Console.WriteLine(Convert.ToString(a, 2));
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
           
        }



        public void ConByteM()
        {
            //конвертация числа в двоичную систему 

            int a = 0;                      
            int i = 0;                       
            int num = 0; 
            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());     
            while (num >= 1)
            {
                a = num % 2;          
                i++;
               num = num / 2;

                Console.Write($"В двоичной -  {a}"); 
            };

            
        }





    
    }


    class Program
    {
        static void Main(string[] args)
        {


            A a = new A();
             a.ConvByteSys();
            Console.WriteLine("---------------------");
             a.ConByteM();
            Console.WriteLine("---------------------");
            MetN();
            Console.ReadKey();


        }

        static void MetN()
        {
            // Нахождение корня n-степени для числа методом Ньютона с заданной точностью

            double n = 0; // степень 
            double A = 0; // число 
            double eps = 0; //точность


           
            Console.WriteLine("Введите число:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите корень n:");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите точность ");
            eps = Convert.ToDouble(Console.ReadLine());


            double x0 = A / n;
            double x1 = (1 / n) * ((n - 1) * x0 + A / (Math.Pow(x0, n - 1)));
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
            }
            Console.WriteLine($"Корень {n}-степени для числа {A} = [{x1}]");

            double a = Convert.ToInt32(Math.Pow(x1, n)); //проверка 

        Console.WriteLine($"Вы ввели число  [{a}]");
        }
    }
}
