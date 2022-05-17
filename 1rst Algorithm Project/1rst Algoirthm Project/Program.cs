using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace _1rst_Algoirthm_Project
{
    internal class Program
    {

        class Prime
        {

            //int second = 0;
            //bool == false;
            static bool PrimeChecker(int n)
            {
                // Automaticly gets rid of 1 and 0 
                if (n == 1 || n == 0)
                {
                    return false;
                }

                // Checks if the number is prime or not, if false it wont output, if true it will output
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            static void PrimeCheckerv2(int limit)
            {
                

                // 2 and 3 are known to be prime
                if (limit > 2)
                    Console.Write(2 + " ");

                if (limit > 3)
                    Console.Write(3 + " ");

                // Initialise the sieve array with
                // false values
                bool[] sieve = new bool[limit + 1];

                for (int i = 0; i <= limit; i++)
                    sieve[i] = false;

                /* Mark sieve[n] is true if one of the
                following is true:
                a) n = (4*x*x)+(y*y) has odd number
                   of solutions, i.e., there exist
                   odd number of distinct pairs
                   (x, y) that satisfy the equation
                   and    n % 12 = 1 or n % 12 = 5.
                b) n = (3*x*x)+(y*y) has odd number
                   of solutions and n % 12 = 7
                c) n = (3*x*x)-(y*y) has odd number
                   of solutions, x > y and n % 12 = 11 */
                for (int x = 1; x * x <= limit; x++)
                {
                    for (int y = 1; y * y <= limit; y++)
                    {

                        // This part does all the prime calculators
                        int n = (4 * x * x) + (y * y);
                        if (n <= limit
                            && (n % 12 == 1 || n % 12 == 5))

                            sieve[n] ^= true;

                        n = (3 * x * x) + (y * y);
                        if (n <= limit && n % 12 == 7)
                            sieve[n] ^= true;

                        n = (3 * x * x) - (y * y);
                        if (x > y && n <= limit
                            && n % 12 == 11)
                            sieve[n] ^= true;
                    }
                }

                // Sets the timne when the code stops running
                DateTime endAt2 = DateTime.Now.AddMinutes(2);

                // Mark all multiples of squares as non-prime
                for (int r = 5; r * r < limit; r++)
                {
                    if (sieve[r] && endAt2 > DateTime.Now)
                    {
                        for (int i = r * r; i < limit;
                             i += r * r)
                            sieve[i] = false;
                    }
                }

                int second = 0;
                // Prints Every Prime number
                for (int a = 5; a <= limit; a++)
                {
                    if (sieve[a] && endAt2 > DateTime.Now)
                    {
                        Console.Write(a + " ");
                        second++;

                    }
                    else if (endAt2 < DateTime.Now)
                    {
                        limit = 0;
                    }
                }
                
                Console.WriteLine();
                // Prints the prime number count
                Console.WriteLine("Total Primes for 2nd Method: " + second);
            }


            static void Main(string[] args)
            {
                int NTC = 1000000000;
                int first = 0;
                //int second2 = 0;

                DateTime endAt = DateTime.Now.AddMinutes(2);



                while (endAt > DateTime.Now)
                {

                    for (int i = 1; i <= NTC; i++)
                    {
                        if (PrimeChecker(i) && endAt > DateTime.Now)
                        {
                            Console.Write(i + " ");
                            first++;
                        }
                        else if (endAt < DateTime.Now) 
                        {
                            //first = i;
                            NTC = 0;
                        }
                    }
               }
                Console.WriteLine(/*This is a spacer*/);
                Console.WriteLine(/*This is a spacer*/);
                Console.WriteLine(/*This is a spacer*/);

                Console.WriteLine("2ND METHOD (WILL TAKE 30 Seconds to Start)");
                
                
                NTC = 1000000000;
                // Runs the 2nd algorithm
                PrimeCheckerv2(NTC);

                Console.WriteLine(/*This is a spacer*/);
                Console.WriteLine(/*This is a spacer*/);
                Console.WriteLine(/*This is a spacer*/);
                Console.WriteLine("First Highest: " + first);
                Console.WriteLine("Press Enter to Close");
                Console.WriteLine(/*This is a spacer*/);
                Console.WriteLine(/*This is a spacer*/);
                Console.ReadLine();


            }
        }

        
    }
}
