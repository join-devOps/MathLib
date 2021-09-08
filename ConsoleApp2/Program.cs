using System;
using System.IO;
using MathLib;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + @"\test.txt";
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }

            Random rand = new Random();
            
            int kol = rand.Next(2, 6);
            double[] nums = new double[kol];

            for (int i = 0; i < kol; i++)
            {
                nums[i] = rand.Next(1, 5);
            }
            for (int i = 0; i < kol; i++)
            {
                Console.Write(nums[i] + " , ");
                File.AppendAllText(path, nums[i] + " , \t");
            }
            File.AppendAllText(path, "\n");
            Console.WriteLine("");

            Console.WriteLine("Sum = " + MathCl.Sum(nums));
            Console.WriteLine("Mul = " + MathCl.Mul(nums));
            Console.WriteLine("Average = " + MathCl.Average(nums));
            Console.WriteLine("GeomAverage = " + MathCl.GeomAverage(nums));

            File.AppendAllText(path, "Sum = " + MathCl.Sum(nums) + "\n");
            File.AppendAllText(path, "Mul = " + MathCl.Mul(nums) + "\n");
            File.AppendAllText(path, "Average = " + MathCl.Average(nums) + "\n");
            File.AppendAllText(path, "GeomAverage = " + MathCl.GeomAverage(nums));

            Console.WriteLine("ArrSort = " + Arranges.ArrSort(nums, false));

            Console.ReadKey();
        }
    }
}