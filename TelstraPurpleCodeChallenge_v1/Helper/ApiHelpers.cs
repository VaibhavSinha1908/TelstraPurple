using System;
using System.Collections.Generic;
using System.Text;

namespace TelstraPurpleCodeChallenge_v1.Helper
{
    public class ApiHelpers
    {
        public long Fibonacci(long param)
        {
            long a = 0, b = 1, c = 0;

            // To return the first Fibonacci number  
            if (param == 0) return a;
            checked
            {
                for (int i = 2; i <= param; i++)
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
            string[] strWordsArr = s.Split(' ');
            StringBuilder strWords = new StringBuilder();
            foreach (var str in strWordsArr)
            {
                var reverseStr = ReverseWord(str);
                strWords.Append(reverseStr + " ");
            }

            return strWords.ToString().TrimEnd(' ');
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