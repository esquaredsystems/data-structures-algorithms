using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] useCases = 
            {
                "a+b*c", // Should output abc*+
                "(5-2)*(3+7)", // Should output 52-37+*
                "(((p-q)*r)+s)/t", // Should output pqr*-st/+
            };
            foreach (string infix in useCases)
            {
                string postfix = InfixToPostfix(infix);
                Console.WriteLine($"Postfix equivalent of {infix} is {postfix}\n");
            }
            // CAUTION! Since we are only working on a string of single characters,
            // therefore this function will fail if any of the operations results in a 
            // number of more than 1 digit. For example, 34* = 12 which is 2 digits.
            EvaluatePostfix("52-12+*");

            Console.ReadKey();
        }

        public static string InfixToPostfix(string infix)
        {
            // Enclose the incoming string in starting and ending parentheses
            infix = '(' + infix + ')';
            string postfix = "";    // This will be returned
            Stack<char> stack = new Stack<char>();  // Initialize an empty stack
            foreach(char c in infix)
            {
                // Operators and starting brackets will be pushed to stack
                if (c == '(' || c == '+' || c == '-' || c == '*' || c == '/')
                {
                    stack.Push(c);
                    Console.WriteLine($"Pushing {c} to Stack.");
                }
                else if (c == ')')
                {
                    // Keep popping until next character is closing bracket
                    while (stack.Peek() != '(') 
                    {
                        char top = stack.Pop();
                        postfix += top;
                        Console.WriteLine($"Popped {top} and added to Postfix.");
                    }
                }
                // Operands are appended to postfix
                else
                {
                    postfix = postfix + c;
                }
                Console.WriteLine($"Postfix is now {postfix}");
            }
            // Empty the Stack and append to postfix whatever remains
            while (stack.Count > 0)
            {
                char top = stack.Pop();
                if (top != '(' && top != ')')
                {
                    postfix += top;
                }
            }
            return postfix;
        }

        public static void EvaluatePostfix(string postfix)
        {
            Stack<char> stack = new Stack<char>();  // Initialize an empty stack
            foreach (char c in postfix)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    // Pop two elements and convert to integers
                    int a = Int16.Parse(stack.Pop().ToString());
                    int b = Int16.Parse(stack.Pop().ToString());
                    int value = 0;
                    // Calculate the value
                    switch (c)
                    {
                        case '+':
                            value = b + a;
                            break;
                        case '-':
                            value = b - a;
                            break;
                        case '*':
                            value = b * a;
                            break;
                        case '/':
                            value = b / a;
                            break;
                    }
                    // Push the value to stack
                    stack.Push(value.ToString()[0]);
                }
                else
                {
                    stack.Push(c);
                }
            }
            Console.WriteLine(stack.Pop());
        }

        
    }
}
