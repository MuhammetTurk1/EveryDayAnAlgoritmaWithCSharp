namespace EASY_10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //1.Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

            //Sample Input:
            //1, 2
            //3, 2
            //2, 2
            //Expected Output:
            //3
            //5
            //12
            #region Solution

            Console.WriteLine("first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            var result = (a == b) ? sum * 3 : sum;
            Console.WriteLine(result);
            #endregion



        }
    }
}