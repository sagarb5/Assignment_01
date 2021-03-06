﻿using System;

namespace Assignment_01 // Sagar Billore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ques 1 = Print Prime Numbers.
            int x = 11, y = 33; 
            printPrimeNumbers(x, y);

            // Ques 2 = GetSeries Result
            double n1 = 5;
            double r1 = getseriesresult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadKey();

            // Ques 3 = Convert Decimal To Binary. 
            long n2 = 15;
            long r2 = decimalTobinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey();

            // Ques 4 = Convert Binary To Decimal.
            long n3 = 1111;
            long r3 = BinarytoDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey();

            // Ques 5 = Print a Triangle with "*".
            int nvalue = 5;
            PrintTriangle(nvalue);

            // Ques 6 = Compute the Frequency of numbers in the array.
            int[] a = new int[10] { 1, 2, 2, 2, 1, 1, 4, 4, 5, 8 };
            ComputeFrequency(a);

            /* 
       From this assignment I got to understand how to use different types of methods in an efficient manner.
       Also learnt the importance of try and catch block, which earlier I used not to work with very often.
       Was able to Brush up some old concepts.

       */
        }
        // Method to print prime nubers in a certain range.
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int flag;
                Console.WriteLine("Prime Numbers are: ");
                int i, j = 0;
                for (i = x; i <= y; i++)
                {
                    flag = 0;
                    for (j = 2; j < x - 1; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine(i);
                    }
                }// end of for loop
                Console.ReadKey();
            }// end of try
            catch
            {
                Console.WriteLine("Exception Occured while computing printPrimeNumbers()");
            }// end of catch
        }// end of prime number method

        // Method to get the result of series
        public static double getseriesresult(double n)
        {
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    double fact = getfact(i);
                    if (i % 2 != 0) // checking the divisibility of i with 2.
                    {
                        sum1 += fact / (i + 1);

                    }
                    else
                    {
                        sum2 -= fact / (i + 1);
                    }
                    sum = sum1 + sum2;
                }// end of for loop
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }// end of catch
            return sum; // returns the value of sum of the series
        }
        public static int getfact(int n) // method to calculate factorial.
        {
            int fact = 1;
            while (n > 0)
            {
                fact = fact * n;
                n--;
            }
            return fact; // returns the factorial
        }// end of factorial method


        // Method to convert Decimal To Binary.
        public static long decimalTobinary(long n)
        {
            long binfun = 0;
            try
            {
                long num = n;
                long q;
                string r = "";
                while (num >= 1)
                {
                    q = num / 2;
                    r += (num % 2).ToString();
                    num = q;
                }
                string bin = "";
                for (int i = r.Length - 1; i >= 0; i--)
                {
                    bin = bin + r[i];

                }// end of for loop
                binfun = Convert.ToInt64(Convert.ToDecimal(bin));
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing decimalTobinary()");
            }// end of catch
            return binfun; // returns the binary value.
        }// end of decimal to binary method


        // Method to convert Binary to decimal.
        public static long BinarytoDecimal(long n)
        {
            long decimal_val = 0;
            try
            {
                long rem;
                long base_val = 0;
                string binary_val = n.ToString();
                char[] c = binary_val.ToCharArray();
                Array.Reverse(c);
                while (n > 0)
                {
                    rem = n % 10;
                    if (rem == 1)  // to check the value of remainder, whether 1 or not.
                    {
                        decimal_val = decimal_val + power(base_val);  // computing decimal value of each digit if remainder is 1 using pow function
                        base_val++;
                    }
                    else
                    {
                        base_val++;
                    }
                    n = n / 10;
                }
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing BinaryToDecimal()");
            }// end of catch
            return decimal_val; // returns the value of decimal
        }
        public static long power(long n)// method to calculate power
        {
            long res = 1;
            for (int i = 0; i < n; i++)
            {
                res = res * 2;   // multiplying the number 2 with n number of times
            }// end of for loop
            return res;
        }
        // end of binary to decimal conversion method.

        // Method to print a Triangle with "*".
        public static void PrintTriangle(int num)
        {
            try
            {
                int i, j, k; // declaring integers
                for (i = 0; i < num + 1; i++)
                {
                    for (j = num; j > i; j--)
                    {
                        Console.Write(" ");
                    }// end of for loop
                    for (k = 0; k < (2 * i - 1); k++)
                    {
                        Console.Write("*");
                    }// end of for loop
                    Console.WriteLine();

                    Console.ReadLine();
                }// end of for loop
                Console.ReadKey();
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
            }// end of catch
        }// End of PrintTriangle method.

        // Method to Compute Frequency
        public static void ComputeFrequency(int[] a)
        {
            int[] unique = new int[a.Length];
            try
            {
                Console.WriteLine("Number - Frequency");
                for (int i = 0; i < a.Length; i++)
                {
                    if (!ScanForElement(unique, a[i]))
                    {
                        int k = 1;
                        for (int j = i + 1; j < a.Length - 1; j++)
                        {
                            if (a[i] == a[j])
                            {
                                unique[i] = a[i];
                                k = k + 1;
                            }
                        }
                        Console.WriteLine(a[i] + "      -     " + k);
                    }// end of for loop
                }
                Console.ReadLine();
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }// end of catch
        }
        public static bool ScanForElement(int[] array, int b)
        {
            foreach (int a in array)
            {
                if (a == b)
                {
                    return true;
                }
            }// end of for loop
            return false;
        }// end of Compute frequency Method  
    }
}
