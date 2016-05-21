using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given the following sequence of numbers:
//•	S1 = N
//•	S2 = S1 + 1
//•	S3 = 2* S1 + 1
//•	S4 = S1 + 2
//•	S5 = S2 + 1
//•	S6 = 2* S2 + 1
//•	S7 = S2 + 2
//•	…
//Using the Queue<T> class, write a program to print its first 50 members for given N.



namespace _05_SequeceWithQueue
{
    class SequenceWithQueue
    {
        public static void Main(string[] args)
        {
            long n = Int64.Parse(Console.ReadLine());

            Queue <long> sequenceQ = new Queue<long>();
            List<long> sequenceFinal = new List<long>();                      

            long s = (long)n; //number to enqueue      

            long s1=0;
            long s2=0;
            long s3=0;      

            sequenceQ.Enqueue(s);       //0  
            sequenceFinal.Add(s);       //0  

            for (int i = 0; i < 50; i++)
            {

                s = sequenceQ.Dequeue();

                s1 = s + 1;
                s2 = 2 * s + 1;
                s3 = s + 2; 
                                
                sequenceQ.Enqueue(s1);       
                sequenceQ.Enqueue(s2);       
                sequenceQ.Enqueue(s3);      

                sequenceFinal.Add(s1);
                sequenceFinal.Add(s2);
                sequenceFinal.Add(s3); 
            }
                       
            for (int i = 0; i < 50; i++)
            {
                Console.Write(sequenceFinal[i]+" ");
            }
         }
    }
}
