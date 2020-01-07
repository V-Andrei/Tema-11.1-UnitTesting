using System;
using System.Text;

namespace Tema_11._1_UnitTesting
{
    public class StringsUtils
    {

        public string Reverse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("Invalid input");
            }
            else if (str.Length.Equals(0))
            {
                throw new ArgumentException("Exception: Empty string: ");
            }
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            reverse(charArray);
            String revStr = new String(charArray);
            return revStr;
        }

        public static void reverse(char[] str)
        {
            int r = str.Length - 1;
            int l = 0;

            while (l < r)
            {
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;
                else
                {
                    Swap(ref str[r], ref str[l]);
                    l++;
                    r--;
                }
            }
        }

        static void Swap<T>(ref T left, ref T right)
        {
            T tmp;
            tmp = left;
            left = right;
            right = tmp;
        }
    }
}
