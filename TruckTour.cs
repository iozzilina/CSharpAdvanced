using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 6.	Truck Tour
//Suppose there is a circle. There are N petrol pumps on that circle.
//Petrol pumps are numbered 0 to (N−1) (both inclusive).
//
//You have two pieces of information corresponding to each of the petrol pump: 
//(1) the amount of petrol that particular petrol pump will give, and 
//(2) the distance from that petrol pump to the next petrol pump.
//
//Initially, you have a tank of infinite capacity carrying no petrol.
//You can start the tour at any of the petrol pumps.
//Calculate the first point from where the truck will be able to complete the circle.
//Consider that the truck will stop at each of the petrol pumps.
//The truck will move one kilometer for each liter of the petrol.
//
//Input Format: The first line will contain the value of N.
//The next N lines will contain a pair of integers each, i.e.the amount of petrol that petrol pump will give 
//and the distance between that petrol pump and the next petrol pump.
//
//Output Format: An integer which will be the smallest index of the petrol pump from which we can start the tour.
//
//Constraints: 
//1 ≤ N ≤ 1000001
//1 ≤ amount of petrol, distance ≤ 1000000000


//Input Output
//3
//1 5
//10 3
//3 4

//Output
//	1



namespace _06_TruckTour
{
    class TruckTour
    {

        static void Main(string[] args)       
        {
            int n = Int32.Parse(Console.ReadLine());

            Queue<GasPump> pumpsQ = new Queue<GasPump>();
            List<GasPump> pumpsTestL = new List<GasPump>();

            // create the Pump objects from input and add them to queue.
            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = Int32.Parse(pumpInfo[1]);
                int amountOfGas = Int32.Parse(pumpInfo[0]);                

                GasPump pump = new GasPump(distanceToNext, amountOfGas,i);
                pumpsQ.Enqueue(pump);                               
            }

            bool completeJourney = false;
            GasPump starterPump = null;
        
            while (completeJourney == false)
            {

                starterPump = pumpsQ.Dequeue(); //set starting point
                pumpsQ.Enqueue(starterPump);    //encue starting pump to main queue in case it does not work out
                pumpsTestL = pumpsQ.ToList();   //convert the current queue to list for inner cycle

                GasPump currentPump = starterPump; // set the current to the starting point

                int gasInTank = starterPump.amountOfGas - starterPump.distanceToNext;// calculate ammount of gas after travel to second pump

                if (gasInTank < 0) // if journey cannot be even started, start the check from the next station.
                {
                    continue;
                }

                for (int i = 0; i < n; i++) // run cycle for the remaining number of pumps on the generated list
                {
                    if (gasInTank<0) // if journey cannot be completed, start the check from the next station.
                    {
                        break;
                    }

                    currentPump = pumpsTestL[i];//get next pump
                    gasInTank += currentPump.amountOfGas - currentPump.amountOfGas;
                }

                completeJourney = true;         

            }           

            Console.WriteLine(starterPump.indexOfPump);
        }


        public class GasPump
        {
            public int distanceToNext;
            public int amountOfGas;
            public int indexOfPump;

            // constructor
            public GasPump(int distanceToNext, int amountOfGas, int indexOfPump)
            {
                this.distanceToNext = distanceToNext;
                this.amountOfGas = amountOfGas;
                this.indexOfPump = indexOfPump;
            }
        }
    }
}
