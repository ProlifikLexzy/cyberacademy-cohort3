using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Library
{
    public static class StringExtension
    {

        public static int SearchByKeyword(this string input, string keyword)
        {
            return input.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsValidTelNo(this string input)
        {
            return input.Length == 11 ? true : false;
        }

        public static bool IsValidEmailAddress(this string input)
        {
            return input.Contains("@");
        }
        //static StringExtension()
        //{

        //}
    }
}
