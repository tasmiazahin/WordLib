using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLib
{
    public class Word
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new NullReferenceException("Input can not be empty!!");
            }

            string reverse = string.Empty;
            foreach (char c in input)
            {
                reverse = c + reverse;
            }

            if (input.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
