using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum = int.Parse(Console.ReadLine());
            int[] outputs = new int[testNum];
           


            for (int i = 0; i < testNum; i++) // every test case
            {
                /***/
                int workers = int.Parse(Console.ReadLine());

                int[] starts = new int[workers];
                int[] ends = new int[workers];

                for (int k = 0; k < workers; k++)
                {
                    string taken = Console.ReadLine();
                    starts[k] = int.Parse(taken.Split(' ')[0]); // an array of start time for each worker
                    ends[k] = int.Parse(taken.Split(' ')[1]); // an array of end time for each worker 
                }
                /***/

                // sort the first and second array 

                Array.Sort<int>(starts,
                new Comparison<int>(
                        (i1, i2) => i1.CompareTo(i2)
                ));

                Array.Sort<int>(ends,
                new Comparison<int>(
                        (i1, i2) => i1.CompareTo(i2)
                ));

                // 

                outputs[i] = 0;
                outputs[i] += ends[0] - starts[0];

                // loop to add each differance between the two arrays
                // but u have to check may be the start of the scond worker is less than the end of the first worker .

                for (int m = 1; m < workers; m++)
                {
                    if (starts[m] < ends[m - 1])    
                        outputs[i] += ends[m] - ends[m - 1];

                    if (starts[m] >= ends[m - 1])          
                        outputs[i] += ends[m] - starts[m];
                }

                /***/
            }


            for (int i = 0; i < testNum; i++)
                Console.WriteLine(outputs[i]);

        }
    }
}
