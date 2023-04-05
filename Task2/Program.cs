using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string result = "";
            int maxRes = 0;
            int i = 0;
            while (i < s.Length)
            {
                while (i < s.Length && !result.Contains(s[i]))
                {
                    result += s[i];
                    maxRes = Math.Max(maxRes, result.Length);
                    ++i;
                }

                i -= result.Length;
                ++i;
                result = "";
            }

            return maxRes;
        }
        static void Main(string[] args)
        {
            string s = "afsdgdsg";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }
    }
}
