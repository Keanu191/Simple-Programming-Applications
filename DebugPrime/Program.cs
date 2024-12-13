/* This was created by Keanu Farro: 13/12/2024
 * Program name: DebugPrime
 * 
 * I will be formatting this set of code provided to me and fixing any errors 
 * that are given with this following snippet of code:
 * static void Main(string[] args){Console.Write("Input Max: ");
int max1 = Convert.ToInt32(Console.ReadLine()); PerfectNumber(max1);
Console.Write("Input Max: ");int max2 = 
Convert.ToInt32(Console.ReadLine());
TwinPrimes(max1);Console.WriteLine("\n\nEnd of Program");
Console.readline();}
static void PerfectNumber(int uppperLimit){int divisor, sum;
for (int counter = 0; counter < uppperLimit; counter++){
sum = 0;for (divisor = 1; divisor < counter; divisor++){
if (counter % divisor == 0)sum = sum + divisor;}
if (sum == counter)Console.WriteLine("perfect number is {0}", counter);}}
static void TwinPrimes(int upperLimit){int secondPrime;
int count1 = 0, count2 = 0;for (int i = 3; i < upperLimit; i++){
for (int j = 2; j < i; j++){
if (i % j == 0){count1++;break;}}SecondPrime = i + 2;
for (int k = 2; k < i; k++){if (secondPrime % k == 0){count2++;break;
}}if (count1 == 0 && count2 == 0){Console.WriteLine("twin primes are {0}, {1}", i, i + 2);}count1 = 0; count2 = 0;}}


You need to complete the following tasks:
1.	Create a new Console Application and use the supplied code (copy the code shown below),
2.	Format the code according to CITE coding standards,
3.	Debug and correct all programming errors; ensure the output is correct,
4.	Modify the program so the user can input any reasonable integer,
5.	Add suitable user prompts before each method call,
6.	Add suitable comments at the top of the code,
7.	Add XML comments for each static method,
8.	Add a #Region Directive around the two calculation methods,

 */

internal class Program
{
    // Fix 1: Convert the main method to a private static void to make it to work
    private static void Main(string[] args)
    {
            Console.Write("Input Max: ");
            int max1 = Convert.ToInt32(Console.ReadLine());
            PerfectNumber(max1);
            Console.Write("Input Max: ");
            int max2 = Convert.ToInt32(Console.ReadLine());
            TwinPrimes(max1);
            Console.WriteLine("\n\nEnd of Program");

            // Fix 2: The ReadLine() part of the console.ReadLine function isn't correct due to the r and l being lowercase
            Console.ReadLine();
        
        static void PerfectNumber(int uppperLimit)
        {
            int divisor, sum;
            for (int counter = 0; counter < uppperLimit; counter++)
            {
                sum = 0; for (divisor = 1; divisor < counter; divisor++)
                {
                    if (counter % divisor == 0) sum = sum + divisor;
                }
                if (sum == counter)
                {
                    Console.WriteLine("perfect number is {0}", counter);
                }

            }
        }
        static void TwinPrimes(int upperLimit)
        {
            int secondPrime;
            int count1 = 0, count2 = 0;
            for (int i = 3; i < upperLimit; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) { count1++; break; }
                }
                // Fix 3: When trying to call the integer secondPrime the S is capital instead of being lowercase like how it was written
                secondPrime = i + 2;
                for (int k = 2; k < i; k++)
                {
                    if (secondPrime % k == 0)
                    {
                        count2++;
                        break;
                    }
                }
                if (count1 == 0 && count2 == 0)
                {
                    Console.WriteLine("twin primes are {0}, {1}", i, i + 2);
                }
                count1 = 0;
                count2 = 0;
            }
        }
    }
}