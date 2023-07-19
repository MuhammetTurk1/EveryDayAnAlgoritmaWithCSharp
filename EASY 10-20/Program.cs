using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace EASY_10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Example
            //1.Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

            //Sample Input:
            //1, 2
            //3, 2
            //2, 2
            //Expected Output:
            //3
            //5
            //12
            #endregion
            #region Solution

            //Console.WriteLine("first number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("second");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int sum = a + b;

            //var result = (a == b) ? sum * 3 : sum;
            //Console.WriteLine(result);
            #endregion


            #region Example
            //2.Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference
            //Sample Input:
            //53
            //30
            //51
            //Expected Output:
            //6
            //21
            //0
            #endregion
            #region Solition
            
            //static int AbsoluteNumber(int k )
            //{
            //    int difference = k - 51;
            //    return difference>0 ? difference*3 : difference;
            //}

            ////MAİN
            //int[] numbers = {53,30,51};
            //foreach (var item in numbers)
            //{
            //    var result = AbsoluteNumber(item);
            //    Console.Write(result);
            //}


            #endregion
        }
    }
}