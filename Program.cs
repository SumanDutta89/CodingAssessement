using System;
using System.Collections.Generic;
using System.Text;

namespace SpellTheNumber
{
    public class Program
    {
        private static readonly string[] units =
        {
            string.Empty, "One ", "Two ", "Three ", "Four ", "Five ", "Six ",
            "Seven ", "Eight ", "Nine ", "Ten ", "Eleven ","Twelve ",
            "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ",
            "Seventeen ", "Eighteen ", "Nineteen "
        };

        private static readonly string[] index =
        {
            string.Empty, string.Empty, "Twenty ", "Thirty ", "Forty ", "Fifty ",
            "Sixty ", "Seventy ", "Eighty ", "Ninety "
        };

        static void Main(string[] args)
        {
            var numberToWord = new Program();
            var str = numberToWord.convertToWord(1000340);
            Console.WriteLine(str);
            Console.ReadKey();
        }
        /// <summary>
        /// Code for Spliting the Digit and adding suffix
        /// </summary>
        /// <param name="number">The Remainder Number</param>
        /// <param name="suffix">Suffix that will appended</param>
        /// <returns></returns>
        private string convertToDigit(int number, String suffix)
        {
            if (number == 0)
            {
                return string.Empty;
            }

            if (number > 19)
            {
                return index[number / 10] + units[number % 10] + suffix;
            }
            else
            {
                return units[number] + suffix;
            }
        }
        /// <summary>
        /// Main Function to split and convert 
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns></returns>
        public string convertToWord(int number)
        {
            StringBuilder res = new StringBuilder();
            res.Append(convertToDigit(((number / 10000000) % 100), "Crore "));
            res.Append(convertToDigit(((number / 100000) % 100), "Lakh "));
            res.Append(convertToDigit(((number / 1000) % 100), "Thousand "));
            res.Append(convertToDigit(((number / 100) % 10), "Hundred "));
            if ((number > 100) && (number % 100 != 0))
            {
                res.Append("and ");
            }
            res.Append(convertToDigit((number % 100), string.Empty));

            return Convert.ToString(res).Trim();
        }
    }
}
