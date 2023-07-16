using System;

namespace EASY
{
    using Microsoft.VisualBasic;
    using System;
    using System.ComponentModel;



    //Write a C# Sharp program to find the century of a given year.

    //Sample Data:
    //(1435) -> "15th century"
    //(1567) -> "16th century"
    //(1921) -> "20th century"
    //(2014) -> "21st century"
    #region Solution
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a year:");
    //        int year = Convert.ToInt32(Console.ReadLine());

    //        string century = GetCentury(year);

    //        Console.WriteLine($"The century of {year} is {century}.");
    //    }

    //    static string GetCentury(int year)
    //    {
    //        int century = (year - 1) / 100 + 1;
    //        string suffix = GetSuffix(century);

    //        return $"{century}{suffix} century";
    //    }

    //    static string GetSuffix(int century)
    //    {
    //        if (century >= 11 && century <= 13)
    //        {
    //            return "th";
    //        }

    //        int lastDigit = century % 10;

    //        switch (lastDigit)
    //        {
    //            case 1:
    //                return "st";
    //            case 2:
    //                return "nd";
    //            case 3:
    //                return "rd";
    //            default:
    //                return "th";
    //        }
    //    }
    //}
    #endregion



    //1. Two Sum
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.


    //Example 1:

    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    //Example 2:

    //Input: nums = [3, 2, 4], target = 6
    //Output: [1,2]
    //Example 3:

    //Input: nums = [3, 3], target = 6
    //Output: [0,1]
    #region Solution
    //public class Solution
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = {1,2,3,8,11};
    //        int[] ints = TwoSum(numbers, 19);
    //        Console.WriteLine(ints[0] +","+ints[1]);
    //    }
    //    public static int[] TwoSum(int[] nums, int target)
    //    {
    //        for (int i = 0; i < nums.Length - 1; i++)
    //        {
    //            for (int j = i + 1; j < nums.Length; j++)
    //            {
    //                if (nums[i] + nums[j] == target)
    //                    return new[] { i, j };
    //            }

    //        }
    //        return new int[] { };

    //    }
    //}
    #endregion



    //    Given an integer x, return true if x is a palindrome and false otherwise.

    //Example 1:

    //Input: x = 121
    //Output: true
    //Explanation: 121 reads as 121 from left to right and from right to left.
    //Example 2:

    //Input: x = -121
    //Output: false
    //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    //Example 3:

    //Input: x = 10
    //Output: false
    //Explanation: Reads 01 from right to left.Therefore it is not a palindrome.
    #region Solution
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        bool a = mami();
    //        Console.WriteLine(a);
    //        //121 true //123 false
    //    }

    //    public static bool mami()
    //    {
    //        var number = Console.ReadLine();
    //        var palidrome = "";
    //        for (int i = number.Length - 1; i >= 0; i--)
    //        {
    //            palidrome += number[i];
    //        }
    //        //Console.WriteLine(palidrome);

    //        //soruda bool dön diyor
    //        return palidrome == number ? true : false;
    //    }



    //}

    #endregion



    //    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    //Symbol Value
    //I             1
    //V             5
    //X             10
    //L             50
    //C             100
    //D             500
    //M             1000
    //For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.

    //Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:

    //I can be placed before V (5) and X(10) to make 4 and 9. 
    //X can be placed before L(50) and C(100) to make 40 and 90. 
    //C can be placed before D(500) and M(1000) to make 400 and 900.
    //Given a roman numeral, convert it to an integer.



    //Example 1:

    //Input: s = "III"
    //Output: 3
    //Explanation: III = 3.
    //Example 2:

    //Input: s = "LVIII"
    //Output: 58
    //Explanation: L = 50, V= 5, III = 3.
    //Example 3:

    //Input: s = "MCMXCIV"
    //Output: 1994
    //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    #region Solution
    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        string roman=Console.ReadLine();
    //       int k = RomanToInt(roman);
    //        Console.WriteLine(k);
    //    }


    //    private static readonly Dictionary<char, int> dict =
    //     new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

    //    public static int RomanToInt(string s)
    //    {

    //        //special situations
    //        s = s.Replace("IV", "IIII");
    //        s = s.Replace("IX", "VIIII");
    //        s = s.Replace("XL", "XXXX");
    //        s = s.Replace("XC", "LXXXX");
    //        s = s.Replace("CD", "CCCC");
    //        s = s.Replace("CM", "DCCCC");

    //        int result = 0;

    //        foreach (var ch in s)
    //        {
    //            result += dict[ch];
    //        }

    //        return result;
    //    }
    //}
    #endregion



    //    Given a number n, for each integer i in the range from 1 to n inclusive, print one value
    //per line as follows:

    //If i is a multiple of both 3 and 5, print FizzBuzz.
    //If i is a multiple of 3 (but not 5), print Fizz.
    //If i is a multiple of 5 (but not 3), print Buzz.
    //If i is not a multiple of 3 or 5, print the value of i.

    //Function Description
    //Complete the function fizzBuzz in the editor below.
    //fizzBuzz has the following parameter(s):
    //int n:  upper limit of values to test (inclusive)
    //Returns:    NONE
    //Prints:
    //    The function must print the appropriate response for each value i in the set { 1, 2, ...n} in ascending order, each on a separate line.


    //örnek ; kullanıcı 15 girerse =>

    //ÇIKTI ==>
    //1     
    //2
    //Fizz
    //4
    //Buzz
    //Fizz
    //7
    //8
    //Fizz
    //Buzz
    //11
    //Fizz
    //13
    //14
    //FizzBuzz
    #region Solution
    //class Result
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Lütfen Bir sayı giriniz");
    //        int n = Convert.ToInt32(Console.ReadLine().Trim());

    //        Result.fizzBuzz(n);
    //    }

    //    public static void fizzBuzz(int n)
    //    {

    //        for (int i = 1; i <= n; i++)
    //        {
    //            if (i % 3 == 0 && i % 5 == 0)
    //            {
    //                Console.WriteLine("FizzBuzz");
    //            }
    //            else if (i % 3 == 0)
    //            {
    //                Console.WriteLine("Fizz");
    //            }
    //            else if (i % 5 == 0)
    //            {
    //                Console.WriteLine("Buzz");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i);
    //            }
    //        }

    //    }

    //}
    #endregion

    //    Input Format

    //1.an integer n(size of array)
    //2.array of size n.
    //Output Format
    //an integer representing new length
    //Sample Input
    //3
    //1 1 2 or 
    //Sample Output
    //2
    //Explanation
    //Given input array A = [1,1,2],
    //Your function should return length = 2, and A is now[1, 2].

    //[1,2,2,2,2,3,3,4,4,5,5,5,5,5] => [1,2,3,4,5]
    #region Solition

    //Solution1
    //class problem
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Kaçlık dizi oluşturmak istiyorsunuz;");
    //        int sayi1 = Convert.ToInt32(Console.ReadLine());
    //        List<int> list= new List<int>();
    //        for (int i = 0; i < sayi1; i++)
    //        {
    //            int k = Convert.ToInt32(Console.ReadLine());
    //            list.Add(k);
    //        }

    //        List<int>list22 = new List<int>();
    //        for (int i = 0; i < list.Count(); i++)
    //        {
    //            for (int j = 0; j < list.Count(); j++)
    //            {
    //                if (list[i] != list[j])
    //                {
    //                    if (!list22.Contains(list[i]))
    //                    {
    //                        list22.Add(list[i]);
    //                    }
    //                }
    //            }
    //        }
    //        Console.WriteLine(list22.Count());
    //    }
    //}


    //Solution2
    //class Program
    //{
    //    static int RemoveDuplicates(int[] nums)
    //    {
    //        if (nums.Length == 0)
    //            return 0;

    //        int uniqueCount = 1;
    //        int currentIndex = 1;

    //        for (int i = 1; i < nums.Length; i++)
    //        {
    //            if (nums[i] != nums[i - 1])
    //            {
    //                nums[currentIndex] = nums[i];
    //                uniqueCount++;
    //                currentIndex++;
    //            }
    //        }

    //        return uniqueCount;
    //    }

    //    static void Main(string[] args)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    //        int newLength = RemoveDuplicates(nums);

    //        Console.WriteLine(newLength);
    //    }
    //}



    #endregion



    #region Example
    //   Q-1 [Algorithm] Write a function to check whether two given strings are anagram of each other or not.An anagram of a string is another string that contains the same characters, only the order of characters can be different. Sample argument: “abcd” - “dabc”
    //Sample output: true

    #endregion
    #region Solution
    //using System.Collections.Generic;

    //public class AnagramChecker
    //{
    //    public static bool AreAnagrams(string str1, string str2)
    //    {
    //        // Remove any whitespace and convert both strings to lowercase
    //        str1 = str1.Replace(" ", "").ToLower();
    //        str2 = str2.Replace(" ", "").ToLower();

    //        // Check if the lengths of the strings are different
    //        if (str1.Length != str2.Length)
    //        {
    //            return false;
    //        }

    //        // Create a dictionary to count the frequency of characters in the strings
    //        Dictionary<char, int> charCount = new Dictionary<char, int>();

    //        // Count the frequency of characters in str1
    //        foreach (char c in str1)
    //        {
    //            if (charCount.ContainsKey(c))
    //            {
    //                charCount[c]++;
    //            }
    //            else
    //            {
    //                charCount[c] = 1;
    //            }
    //        }

    //        // Decrement the character count for str2
    //        foreach (char c in str2)
    //        {
    //            if (charCount.ContainsKey(c))
    //            {
    //                charCount[c]--;
    //                if (charCount[c] == 0)
    //                {
    //                    charCount.Remove(c);
    //                }
    //            }
    //            else
    //            {
    //                // If a character in str2 is not found in str1, they are not anagrams
    //                return false;
    //            }
    //        }

    //        // If the character count dictionary is empty, they are anagrams
    //        return charCount.Count == 0;
    //    }

    //    public static void Main(string[] args)
    //    {
    //        string str1 = "abcd";
    //        string str2 = "dabc";
    //        Console.WriteLine(AreAnagrams(str1, str2));  // Output: True
    //    }
    //}

    #endregion



    #region Example

//    Q-2 [Algorithm] Write a function finding the smallest and largest element in an Unsorted Array.
//Sample argument: [4, 2, 0, 8, 20, 9, 10]
//    Sample output: smallest element: 0 - largest element: 20

    #endregion
    #region Solition
    //public class ArrayMinMax
    //{
    //    public static void FindMinMax(int[] array, out int min, out int max)
    //    {
    //        if (array.Length == 0)
    //        {
    //            throw new ArgumentException("The array cannot be empty.");
    //        }

    //        //I haave to take a referance number or index that ı will compare eachother otherwise wont be wrong
    //        min = array[0];
    //        max = array[0];

    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            if (array[i] < min)
    //            {
    //                min = array[i];
    //            }
    //            else if (array[i] > max)
    //            {
    //                max = array[i];
    //            }
    //        }
    //    }

    //    public static void Main(string[] args)
    //    {
    //        int[] array = { 4, 2, 0, 8, 20, 9, 10 };
    //        int min, max;

    //        FindMinMax(array, out min, out max);

    //        Console.WriteLine($"Smallest element: {min} - Largest element: {max}");
    //    }
    //}

    #endregion


}