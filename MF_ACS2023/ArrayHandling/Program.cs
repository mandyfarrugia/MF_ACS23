using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 2, 5, 8, 11, 14, 17 };

            //or... int[] arrayOfNumbers2 = new int[3] { 2, 5, 8 };
            int[] arrayOfNumbers2 = new int[3]; //An array of a fixed size allowing up to 3 numbers.
            arrayOfNumbers2[0] = 1;
            arrayOfNumbers2[1] = 2;
            arrayOfNumbers2[2] = 3;

            /* Beginners may have the temptation to do the following.
             * However, imagine doing this for 50 elements.
             * You may run the risk of accessing a non-existent index, hence causing an IndexOutOfRange exception. 
             * You may also risk forgetting to list all of the numbers. */
            Console.WriteLine("Displaying all elements in arrayOfNumbers2 by indexing (BAD METHOD): ");
            Console.WriteLine(arrayOfNumbers2[0]);
            Console.WriteLine(arrayOfNumbers2[1]);
            Console.WriteLine(arrayOfNumbers2[2]);

            //However, an array solves this by going through the list.
            Console.WriteLine("\nDisplaying all elements in arrayOfNumbers by looping (GOOD METHOD): ");
            foreach (int number in arrayOfNumbers) //number is a temporary variable and exists until the foreach finishes executing.
            {
                Console.WriteLine(number); //Go through the list and display each element to the console.
            }

            /* The danger of using a traditional array is accidentally using a non-existent index. 
             * If you attempt to access an index which goes beyond the fixed size or a negative index, an exception is thrown. */
            //arrayOfNumbers2[3] = 4;
            //arrayOfNumbers[-1] = 4;

            Console.WriteLine($"\nThe array arrayOfNumbers has {arrayOfNumbers.Length} elements.");
            Console.WriteLine($"The array arrayOfNumbers2 has {arrayOfNumbers2.Length} elements.");

            //or... List<string> names = new List<string>() { "Mandy", "Melanie", "Matthew" };
            List<string> names = new List<string>();
            names.Add("Mandy");
            names.Add("Melanie");
            names.Add("Matthew");

            Console.WriteLine("\nUsing the foreach loop to get all names from the array: ");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"The list currently has {names.Count} names.");

            names.Add("Thomas");

            for(int index = 0; index < names.Count; index++)
            {
                Console.WriteLine($"{index} - {names[index]}");
            }

            /* ElementAt gets an element at a specific location.
             * To get the last element in an array, do <name-of-array>.Count - 1.
             * ElementAt is equivalent to <name-of-array>[index].
             * Therefore, names.ElementAt(names.Count - 1) is equivalent to names[names.Count - 1]. */
            Console.WriteLine($"The list now has {names.Count} names because the name {names.ElementAt(names.Count - 1)} has been added.");

            Console.WriteLine($"\nDoes arrayOfNumbers contain the number 2?: {arrayOfNumbers.Contains(2)}");
            Console.WriteLine($"Does arrayOfNumbers contain the number 9?: {arrayOfNumbers.Contains(9)}");
            Console.WriteLine($"Do any of the names contain the letter e?: {names.Any(name => name.Contains("e"))}");
            Console.WriteLine($"Do all of the names contain the letter a?: {names.All(name => name.Contains("a"))}");

            names.Remove("Thomas");
            names.RemoveAt(0);
            Console.WriteLine($"\nNow the list has {names.Count} names.");

            Console.ReadLine();
        }
    }
}