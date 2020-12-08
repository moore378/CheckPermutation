using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given two strings, write a method to decide if one is a permutation of the other.
/// </summary>
namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is a string";
            string s2 = "is this string a";

            bool z = CheckPerm1(s1, s2);
        }

        public static bool CheckPerm1(string s, string s2)
        {
            var x = s.Split(' ');
            var string2words = s2.Split(' ');

            foreach(var word in string2words)
            {
                if (!x.Contains(word))
                    return false;
         
            }

            return true;
        }
    }
}
