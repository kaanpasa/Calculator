using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplama, cıkarma, bolme, carpma;
            Console.WriteLine("\t--Hesap Makinası--\n\t----Kaan Pasa-----");
            Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            double a = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen işlemi giriniz: ");
            char islem = Convert.ToChar(Console.ReadLine());
            toplama = a + b;
            cıkarma = a - b;
            carpma = a * b;
            bolme = a / b;
            if (islem == '+')
            {
                Console.WriteLine(a+"+"+b+"="+toplama);
            }else if(islem== '-')
            {
                Console.WriteLine(a + "-" + b + "=" + cıkarma);
            }
            else if (islem == '*')
            {
                Console.WriteLine(a + "*" + b + "=" + carpma);
            }
            else if (islem == '/')
            {
                Console.WriteLine(a + "/" + b + "=" + bolme); 
            }else
                Console.WriteLine("Yanlış girdi.");
            Console.ReadKey();
        }
    }
}
