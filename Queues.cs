using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Basic Queue Operations
//Play around with a queue.You will be given an integer N representing the amount of elements to enqueue, 
//an integer S representing the amount of elements to dequeue from the queue and finally 
//an integer X, an element that you should check whether is present in the queue.
//If it is print true on the console, if it’s not print the smallest element currently present in the queue.


namespace _04_Queues
{
    class Queues
    {
        public static void Main(string[] args)
        {

            int[] operations = Console.ReadLine()
                                .Trim()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int[] sequence = Console.ReadLine()
                               .Trim()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            Queue<int> sequenceQ = new Queue<int>();
           
            // enqueue the numbers

            for (int i = 0; i < operations[0]; i++)
            {
                sequenceQ.Enqueue(sequence[i]);
            }

            
            //dequeue the numbers
            for (int i = 0; i < operations[1]; i++)
            {
                sequenceQ.Dequeue();
            }

            //check if que is empty

            if(sequenceQ.Count == 0)
            {
                Console.WriteLine("0");
            }

            // check if number is present

            else if (sequenceQ.Contains(operations[2]))
            {
                Console.WriteLine("true");
            }

            // if number is not presents, print min of sequence
            else
            {
                Console.WriteLine(sequenceQ.Min());
            }
            

        }
    }
}
