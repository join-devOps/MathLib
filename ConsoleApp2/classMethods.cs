using System;
using MathLib;

namespace ConsoleApp2
{
    class classMethods : classFile
    {
        private static void answerSum(double[] nums)
        {
            Console.WriteLine("Sum  => " + MathCl.Sum(nums));
            Console.WriteLine();
        }

        private static void answerMul(double[] nums)
        {
            Console.WriteLine("Mul => " + MathCl.Mul(nums));
            Console.WriteLine();
        }

        private static void answerAverage(double[] nums)
        {
            Console.WriteLine("Average => " + MathCl.Average(nums));
            Console.WriteLine();
        }

        private static void answerGeomAverage(double[] nums)
        {
            Console.WriteLine("GeomAverage => " + MathCl.GeomAverage(nums));
            Console.WriteLine();
        }

        public static void lessons_1(double[,] numbers, byte[] kol, byte variantMethod)
        {
            double[] nums = new double[7];
            if (variantMethod == 1)
            {
                for (byte kolTest = 0; kolTest < 6; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                        //pasteFile("\t" + numbers[kolTest, i]);
                    }
                    Console.WriteLine();
                    answerSum(nums);
                }
                Console.WriteLine();
            }
            if (variantMethod == 2)
            {
                for (byte kolTest = 0; kolTest < 6; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                        //pasteFile("\t" + numbers[kolTest, i]);
                    }
                    Console.WriteLine();
                    answerMul(nums);
                }
                Console.WriteLine();
            }
            if (variantMethod == 3)
            {
                for (byte kolTest = 0; kolTest < 6; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                        //pasteFile("\t" + numbers[kolTest, i]);
                    }
                    Console.WriteLine();
                    answerAverage(nums);
                }
                Console.WriteLine();
            }
            if (variantMethod == 4)
            {
                for (byte kolTest = 0; kolTest < 6; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                        //pasteFile("\t" + numbers[kolTest, i]);
                    }
                    Console.WriteLine();
                    answerGeomAverage(nums);
                }
                Console.WriteLine();
            }

        }

        public static void lessons_2(double[] numbers, double[,] numsMas, double[,] numMas_2, bool dir, byte kol)
        {
            Arranges.ArrSort(numbers, dir);
            {
                Console.Write("ArrSort = ");
                //pasteFile("ArrSort = ", 0, 1);
                for (byte i = 0; i < kol; i++)
                {
                    Console.Write(" " + numbers[i]);
                    //pasteFile("\t", numbers[i], 2);
                }
            }
            Console.WriteLine("");
            //pasteFile("", 0, 3);

            Arranges.ArrFind(numbers, dir);
            Console.Write("ArrFind = ");
            //pasteFile("ArrFind = ", 0, 1);
            //pasteFile("", 0, 3);

            for (int i = 0; i < kol; i++)
            {
                Console.Write(" " + numbers[i]);
                //pasteFile("\t", numbers[i], 2);
            }
            Console.WriteLine("");
            //pasteFile("", 0, 3);

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    Console.Write(numsMas[i, j] + "\t");
                 //   pasteFile("\t", numsMas[i, j], 2);
                }
                Console.WriteLine("");
              //  pasteFile("", 0, 3);
            }
            Console.WriteLine("");
            //pasteFile("", 0, 3);

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    Console.Write(numMas_2[i, j] + "\t");
                   // pasteFile("\t", numMas_2[i, j], 2);
                }
                Console.WriteLine("");
              //  pasteFile("", 0, 3);
            }
            Console.WriteLine("");
            //pasteFile("", 0, 3);

            for (byte i = 0; i < kol; i++)
            {
                for (byte j = 0; j < kol; j++)
                {
                    Console.Write(numsMas[i, j] + "\t");
                   // pasteFile("\t", numsMas[i, j], 2);
                }
                Console.WriteLine("");
               // pasteFile("", 0, 3);
            }
            Console.WriteLine("");
           // pasteFile("", 0, 3);

            Console.WriteLine("ArrDet = " + Arranges.ArrDet(numsMas));
          //  pasteFile("ArrDet = ", Arranges.ArrDet(numsMas), 1);
           // pasteFile("", 0, 3);

            Arranges.MatrixSum(numsMas, numMas_2);
            {
                Console.WriteLine("MatrixSum: ");
             //   pasteFile("MatrixSum: ", 0, 1);
              //  pasteFile("", 0, 3);

                for (byte i = 0; i < kol; i++)
                {
                    for (byte j = 0; j < kol; j++)
                    {
                        Console.Write(numsMas[i, j] + "\t");
                     //   pasteFile("\t", numsMas[i, j], 2);
                    }
                    Console.WriteLine("");
                  //  pasteFile("", 0, 3);
                }
                Console.WriteLine("");
              //  pasteFile("", 0, 3);
            }

            Arranges.MatrixMul(numsMas, numMas_2);
            {
                Console.WriteLine("MatrixMul: ");
              //  pasteFile("MatrixMul: ", 0, 1);
              //  pasteFile("", 0, 3);

                for (byte i = 0; i < kol; i++)
                {
                    for (byte j = 0; j < kol; j++)
                    {
                        Console.Write(numMas_2[i, j] + "\t");
                    //    pasteFile("\t", numsMas[i, j], 2);
                    }
                    Console.WriteLine("");
                  //  pasteFile("", 0, 3);
                }
                Console.WriteLine("");
              //  pasteFile("", 0, 3);
            }
        }
    }
}