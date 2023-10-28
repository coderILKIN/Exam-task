using System;

namespace ExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Ekrana Yigdiginiz bali yazin--");
            byte examPrice = Convert.ToByte(Console.ReadLine());

            if ( examPrice>=0 && examPrice<=100)
            {
                if (examPrice>90 && examPrice<=100)
                {
                    Console.WriteLine("Qiymetiniz:'A' Tebrikler elaci oldunuz");
                }
                else if (examPrice>80 && examPrice<=90)
                {
                    Console.WriteLine("Qiymetiniz:'B' Tebrikler zerbeci oldunuz");
                }
                else if (examPrice>70 && examPrice<=80)
                {
                    Console.WriteLine("Qiymetiniz:'C'");
                }
                else if (examPrice>60 && examPrice<=70)
                {
                    Console.WriteLine("Qiymetiniz:'D'");
                }
                else if (examPrice>50 && examPrice<=60)
                {
                    Console.WriteLine("Qiymetiniz:'E'");
                }
                else
                {
                    Console.WriteLine("Kesildiniz");
                }
            }
            else
            {
                Console.WriteLine("Duzgun bal daxil edin");
            }
        }
    }
}
