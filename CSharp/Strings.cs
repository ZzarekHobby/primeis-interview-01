using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class Strings
    {
        /// <summary>
        /// Implement a string reversal method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse1(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in input.Reverse())
                stringBuilder.Append(c);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Implement a different string reversal method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse2(string input)
        {
            var result = input.ToCharArray().Reverse().ToArray();
            return new string(result);
        }

        /// <summary>
        /// Implement a string truncation function that safely truncates the input without throwning an exception. Return null if input is null.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SafeTruncate(string input, int length)
        {
            if (input == null)
                return null;

            return new string(input.Take(length).ToArray());
        }

        /// <summary>
        /// return a list of even numbers from the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> EvenNumerics(List<string> input)
        {
            var evenNumbers = FindNumbers(input).Where(x => x % 2 ==0).ToList();

            return evenNumbers;
        }

        private static IEnumerable<int> FindNumbers(List<string> input)
        {
            foreach (var item in input)
            {
                if(int.TryParse(item, out int result)) { 
                    yield return result;
                }            
            }
        }
 
    }
}
