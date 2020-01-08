using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelstraPurpleCodeChallenge_v1.Helper
{
    public class ApiHelpers
    {
        public long Fibonacci(long param)
        {
            long a = 0, b = 1, c;
            // To return the first Fibonacci number  
            if (param == 0) return a;
            checked
            {
                for (long i = 2; i <= param; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            return b;
        }



        public string ReverseWords(string s)
        {
            //convert string to CharArr

            s = s.TrimEnd('\r', '\n');
            char[] chArr = s.ToArray();

            StringBuilder buffer = new StringBuilder();
            StringBuilder finalResult = new StringBuilder();

            foreach (var ch in chArr)
            {
                if (ch == ' ')
                {
                    finalResult.Append(ReverseWord(buffer.ToString()) + " ");
                    buffer = new StringBuilder();
                }
                else
                {
                    buffer.Append(ch);
                }
            }
            //Add the last word
            finalResult.Append(ReverseWord(buffer.ToString()) + " ");

            return finalResult.ToString().TrimEnd(' ');
        }



        public string ReverseWord(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string TriangleType(int side1, int side2, int side3)
        {
            List<int> sides = new List<int>();

            sides.Add(side1);
            sides.Add(side2);
            sides.Add(side3);

            sides.Sort();

            //check whether the triangle is possible.
            if (sides[0] + sides[1] <= sides[2])
                return "Error";
            if (sides[0] == sides[1] && sides[1] == sides[2])
            {
                return "Equilateral";
            }
            if ((sides[0] == sides[1] && sides[1] != sides[2]) || (sides[1] == sides[2] && sides[1] != sides[0]))
            {
                return "Isosceles";
            }
            else
                return "Scalene";
        }
    }
}