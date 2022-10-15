using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses("hi(hi)"));
            Console.ReadKey();
        }

        public static bool ValidParentheses(string input)
        {
            int parentheses = 0;
            foreach (char t in input)
            {
                if (t == '(')
                {
                    parentheses++;
                }
                else if (t == ')')
                {
                    parentheses--;

                    if (parentheses < 0)
                    {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }

        public static bool ValidParentheses1(string input)
        {
            input = string.Concat(input.Where(x => "()".Contains(x)));
            while (input.Contains("()"))
            {
                input = input.Replace("()", "");
            }

            return !input.Any();
        }
    }
}
