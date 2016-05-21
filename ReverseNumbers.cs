using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseNunbers
{
    class ReverseNumbers
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Trim()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            Stack<int> numbersStack = new Stack<int>();

            foreach (var number in numbers)
            {
                numbersStack.Push(number);
            }

            // quick print out
            //Console.WriteLine(string.Join(" ",numbersStack));


            while(numbersStack.Count != 0)
            {
                int current = numbersStack.Pop();
                Console.Write(current);

                if(numbersStack.Count != 0)
                {
                    Console.Write(" ");
                }
                                
            }

            Console.WriteLine("\n");
        }
    }
}
