﻿using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Text.Json.Serialization.Metadata;

namespace MethodHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] numbers = { -33, 2, -3, -23, -5 };
            PlusMinus(numbers);
            Console.WriteLine(RemoveSpace("    Kamran   Baxsaliyev"));
            Console.WriteLine(Palindrome("salam"));

        }
        #region task1
        static void PlusMinus(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
        #endregion
        
        
        #region task5
        static string RemoveSpace(string abc)
        { string result = string.Empty;
            for (int i = abc.Length - 1; i >= 0; i--)
            {
                if (abc[i] != ' ')
                {
                    result += abc[i];
                }
            } return result;
        }
        #endregion


        #region task3
        static bool Palindrome(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            if (result == str)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
#endregion  


    }
}