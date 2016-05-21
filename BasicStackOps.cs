using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Play around with a stack. 
//You will be given an integer N representing the amount of elements to push onto the stack, 
//an integer S representing the amount of elements to pop from the stack and finally 
//an integer X, an element that you should check whether is present in the stack. 
//If it is print true on the console, if it’s not print the smallest element currently present in the stack.

//Input Format: On the first line you will be given N, S and X separated by a single space.
//On the next line you will be given N amount of integers.

//Output Format: On a single line print either true if X is present in the stack otherwise print smallest element in the stack. 
//If the stack is empty print 0.




namespace _02_BasicStackOps
{
    class BasicStackOps
    {
        public static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
                            .Trim()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int[] numbers = Console.ReadLine()
                            .Trim()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < operations[0]; i++)
            {
                numbersStack.Push(numbers[i]);
            }

            for (int i = 0; i < operations[1]; i++)
            {
                numbersStack.Pop();
            }

            if(numbersStack.Count == 0)
            {
                Console.WriteLine("0");
            }


            else 
            {
                bool hasNumber = numbersStack.Contains(operations[2]);

                if (hasNumber)
                {
                    Console.WriteLine("true");
                }


                else
                {
                    Console.WriteLine(numbersStack.Min());
                }
                
            }


            
            
        }
    }
}
