using System;

namespace ConsoleApp2
{
    class Program
    {
        static void enter_lesson_1()
        {
            Random rand = new Random();
            byte[] kol1 = new byte[7];
            double[,] nums1 = new double[7, 10];

            for (byte i = 0; i < 6; i++)
            {
                kol1[i] = (byte)rand.Next(2, 6);
            }

            // Для метода сложения
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol1.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol1, 1);

            // Для метода умножения
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol1.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol1, 2);

            // Для метода Average
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol1.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol1, 3);

            // Для метода GeomAverage
            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kol1.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol1, 4);
        }

        static void enter_lesson_2()
        {
            Random rand = new Random();

            bool dir = rand.Next(0, 2) > 0;
            byte[] kolStroka = new byte[6];
            byte[] kolStolbik = new byte[6];
            double[,] nums = new double[10, 10];

            for (byte i = 0; i < 6; i++)
            {
                kolStroka[i] = (byte)rand.Next(2, 7);
                kolStolbik[i] = (byte)rand.Next(2, 7);
            }

            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kolStroka.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(2, 9);
                }
            }
            classMethods.arrSort_arrFind(nums, kolStroka, dir, 1);

            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kolStroka.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(2, 9);
                }
            }
            classMethods.arrSort_arrFind(nums, kolStroka, dir, 2);

            double[,,] numsMatrix = new double[10, 10, 10];

            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
            }
            classMethods.arrDet(numsMatrix, kolStolbik, kolStroka);

            double[,,] numsMatrix_1 = new double[10, 10, 10];
            double[,,] numsMatrix_2 = new double[10, 10, 10];

            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_1[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_2[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
            }
            classMethods.matrixSum_matrixMul(numsMatrix_1, numsMatrix_2, kolStolbik, kolStroka, 1);

            for (byte kolTest = 0; kolTest < 6; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_1[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_2[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
            }
            classMethods.matrixSum_matrixMul(numsMatrix_1, numsMatrix_2, kolStolbik, kolStroka, 2);
        }

        static void Main(string[] args)
        {
            enter_lesson_2();

            Console.ReadKey();
        }
    }
}