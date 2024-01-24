using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaiTap7(); 
        }
        static void BaiTap1()
        {
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = n * (n + 1) / 2;
            Console.WriteLine($"Tong day so tu 1 den {n} la: {sum}");
        }
        static void BaiTap2()
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = (n * (n + 1) * (2 * n + 1)) / 6;
            Console.WriteLine($" Tong cac so tu 1^2 den {n} la: {sum}");
        }
        static void BaiTap3()
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for(int j = 1; j <= n; j++)
            {
                sum += 1.0 / j;
            }
            Console.WriteLine($"Tong cua day so harmonic tu 1 den {n} la: {sum}");
        }
        static void BaiTap4()
        {
            Console.Write(" Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += 1.0 / (2 * i);
            }
            Console.WriteLine($"Tong day so tu 1 den {n} la: {sum} ");
        }
        static void BaiTap5()
        {
            int x, y;
            char PhepToan;
            Console.Write("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phep toan: ");
            PhepToan = Convert.ToChar(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (PhepToan == '+')
                Console.WriteLine(" {0} + {1} = {2}", x, y, x + y);
            else if (PhepToan == '-')
                Console.WriteLine(" {0} - {1} = {2} ", x, y, x - y);
            else if ((PhepToan == 'x') || (PhepToan == '*'))
                Console.WriteLine(" {0} * {1} = {2} ", x, y, x * y);
            else if (PhepToan == '/')
                Console.WriteLine(" {0} / {1} = {2} ", x, y, x / y);
            else
                Console.WriteLine("Ban da nhap sai phep toan.");
            Console.ReadKey();

      }
        static void BaiTap6()
        {
            double r, chuvi, dientich;
            double PI = 3.14;
            Console.Write("Nhap ban kinh r: ");
            r = Convert.ToDouble(Console.ReadLine());
            chuvi = 2 * r * PI;
            Console.WriteLine("Chu vi hinh tron la: {0}", chuvi);
            dientich = PI * r * r;
            Console.WriteLine("Dien tich hinh tron la: {0}", dientich);
        }
        static void BaiTap7()
        {
            int x, y;
            Console.Write(" x = y^2 - 2y + 1");
            Console.WriteLine();
            for(y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine(" y = {0}; x = ({0}^2) - 2({0}) + 1 = {1}", y,x);   
            }
            Console.ReadKey();
        }
        static void BaiTap8()
        { }
        static void BaiTap9()
        { }


    }

}
