using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    internal class EquationAnalyzer
    {

        public static void main(string[] args)
        {
            
        }

        public static bool AreParenthesisBalanced(string equation)
        {
            bool balanced = false;
            Stack<char> stack = new Stack<char>();
            foreach (char c in equation)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) { return false; }
                    char popped = stack.Pop();
                    if (c == ')' && popped != '(') { return false; }
                    if (c == '}' && popped != '{') { return false; }
                    if (c == ']' && popped != '[') { return false; }
                }
            }
            if (stack.Count == 0)
            {
                balanced = true;
            }
            return balanced;
        }

    }
}
