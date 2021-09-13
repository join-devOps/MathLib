﻿using MathLib;
using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void pasteFile(string name, double number, byte variant)
        {
            string path = Directory.GetCurrentDirectory() + @"\test.txt";
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }

            if (variant == 1)
            {
                File.AppendAllText(path, "\n" + name + number);
            }
            if (variant == 2)
            {
                File.AppendAllText(path, number + name);
            }
            if (variant == 3)
            {
                File.AppendAllText(path, "\n");
            }
        }

        static void pasteFile_testMethods(string[] name)
        {
            foreach (string kol in name)
            {
                string path = Directory.GetCurrentDirectory() + kol;
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }
            }

            

        }

        static void lessons_1(double[] numbers, byte kol)
        {
            for (byte i = 0; i < kol; i++)
            {
                Console.Write(numbers[i] + " , ");
                pasteFile(" ", numbers[i], 2);
            }
            Console.WriteLine("");

            Console.WriteLine("Sum = " + MathCl.Sum(numbers));
            pasteFile("Sum = ", MathCl.Sum(numbers), 1);

            Console.WriteLine("Mul = " + MathCl.Mul(numbers));
            pasteFile("Mul = ", MathCl.Mul(numbers), 1);

            Console.WriteLine("Average = " + MathCl.Average(numbers));
            pasteFile("Average = ", MathCl.Average(numbers), 1);

            Console.WriteLine("GeomAverage = " + MathCl.GeomAverage(numbers));
            pasteFile("GeomAverage = ", MathCl.GeomAverage(numbers), 1);

            pasteFile("", 0, 3);
        }

        static void lessons_2(double[] numbers, double[,] numsMas, double[,] numMas_2, bool dir, byte kol)
        {
            Arranges.ArrSort(numbers, dir);
            {
                Console.Write("ArrSort = ");
                pasteFile("ArrSort = ", 0, 1);
                for (byte i = 0; i < kol; i++)
                {
                    Console.Write(" " + numbers[i]);
                    pasteFile("\t", numbers[i], 2);
                }
            }
            Console.WriteLine("");
            pasteFile("", 0, 3);

            Arranges.ArrFind(numbers, dir);
            Console.Write("ArrFind = ");
            pasteFile("ArrFind = ", 0, 1);
            pasteFile("", 0, 3);

            for (int i = 0; i < kol; i++)
            {
                Console.Write(" " + numbers[i]);
                pasteFile("\t", numbers[i], 2);
            }
            Console.WriteLine("");
            pasteFile("", 0, 3);

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    Console.Write(numsMas[i, j] + "\t");
                    pasteFile("\t", numsMas[i, j], 2);
                }
                Console.WriteLine("");
                pasteFile("", 0, 3);
            }
            Console.WriteLine("");
            pasteFile("", 0, 3);

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    Console.Write(numMas_2[i, j] + "\t");
                    pasteFile("\t", numMas_2[i, j], 2);
                }
                Console.WriteLine("");
                pasteFile("", 0, 3);
            }
            Console.WriteLine("");
            pasteFile("", 0, 3);

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    Console.Write(numsMas[i, j] + "\t");
                    pasteFile("\t", numsMas[i, j], 2);
                }
                Console.WriteLine("");
                pasteFile("", 0, 3);
            }
            Console.WriteLine("");
            pasteFile("", 0, 3);

            Console.WriteLine("ArrDet = " + Arranges.ArrDet(numsMas));
            pasteFile("ArrDet = ", Arranges.ArrDet(numsMas), 1);
            pasteFile("", 0, 3);

            Arranges.MatrixSum(numsMas, numMas_2);
            {
                Console.WriteLine("MatrixSum: ");
                pasteFile("MatrixSum: ", 0, 1);
                pasteFile("", 0, 3);

                for (byte i = 0; i < kol; i++)
                {
                    for (byte j = 0; j < kol; j++)
                    {
                        Console.Write(numsMas[i, j] + "\t");
                        pasteFile("\t", numsMas[i, j], 2);
                    }
                    Console.WriteLine("");
                    pasteFile("", 0, 3);
                }
                Console.WriteLine("");
                pasteFile("", 0, 3);
            }

            Arranges.MatrixMul(numsMas, numMas_2);
            {
                Console.WriteLine("MatrixMul: ");
                pasteFile("MatrixMul: ", 0, 1);
                pasteFile("", 0, 3);

                for (byte i = 0; i < kol; i++)
                {
                    for (byte j = 0; j < kol; j++)
                    {
                        Console.Write(numMas_2[i, j] + "\t");
                        pasteFile("\t", numsMas[i, j], 2);
                    }
                    Console.WriteLine("");
                    pasteFile("", 0, 3);
                }
                Console.WriteLine("");
                pasteFile("", 0, 3);
            }
        }

        static void proccessTesting()
        {
            string[] pathFiles_test = { @"\testSum.txt", @"\testMul.txt", @"\testAverage.txt", @"\test_geomAverage.txt" };
            pasteFile_testMethods(pathFiles_test);
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            proccessTesting();

            byte kol = (byte)rand.Next(2, 6);
            double[] nums = new double[kol];
            double[,] numsMas = new double[kol, kol];
            double[,] numMas_2 = new double[kol, kol];
            bool dir = rand.Next(0, 2) > 0;

            for (byte kolTest = 0; kolTest < 20; kolTest++)
            {
                for (byte i = 0; i < kol; i++)
                {
                    nums[i] = rand.Next(1, 5);
                }
            }

            lessons_1(nums, kol);
            Console.WriteLine("");

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    numsMas[i, j] = rand.Next(1, 15);
                    numMas_2[i, j] = rand.Next(1, 15);
                }
            }

            lessons_2(nums, numsMas, numMas_2, dir, kol);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}