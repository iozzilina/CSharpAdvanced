using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//You have an empty sequence, and you will be given N queries.Each query is one of these three types:
//1 x - Push the element x into the stack.
//2    - Delete the element present at the top of the stack.
//3    - Print the maximum element in the stack.
//Input Format: The first line of input contains an integer, N.The next N lines each contain an above mentioned query. 
//(It is guaranteed that each query is valid.)

//Output Format: For each type 3 query, print the maximum element in the stack on a new line.

//Constraints:
//1 ≤ N ≤ 105
//1 ≤ x ≤ 109
//1 ≤ type ≤ 3

/// <summary>
///  need to be optimized for time with a second structure for the max elements storage.
/// </summary>


namespace _03_MaximumElement
{
    class MaximumElement
    {
        public static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            int cmdInputs = Int32.Parse(Console.ReadLine());

            int maxElement = 0;

            for (int i = 0; i < cmdInputs; i++)
            {
                int[] operations = Console.ReadLine()
                            .Trim()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                if (operations[0] == 1)
                {
                    myStack.Push(operations[1]);

                    //if (operations[1] > maxElement)
                    // {
                    //    maxElement = operations[1];
                    // }
                }

                else if (operations[0] == 2)
                {
                     myStack.Pop();
                }
                
                else //if operations[0] == 3
                {
                    Console.WriteLine(myStack.Max());
                    //Console.WriteLine(maxElement);
                }

            }  


        }
    }
}
