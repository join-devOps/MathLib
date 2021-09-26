using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            byte[] kol = new byte[7];
            double[,] nums = new double[7, 10];
            //bool dir = rand.Next(0, 2) > 0;

            for (byte i = 0; i < 6; i++)
            {
                kol[i] = (byte)rand.Next(2, 6);
            }

            // Для метода сложения
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums, kol, 1);

            // Для метода умножения
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums, kol, 2);

            // Для метода Average
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums, kol, 3);

            // Для метода GeomAverage
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums, kol, 4);

            Console.ReadKey();
        }
    }
}