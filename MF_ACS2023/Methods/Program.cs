using System;

namespace Methods
{
    public class Program
    {
        /* To create a method, you must specify a return type, followed by the name of the method and any parameters. 
         * Parameters are optional, it depends on the scenario and what you want the method to do.
         * The access modifier (whether the method is private or public) does not matter at this point. */

        /* This method has a return type (returns a sum of two numbers) and two parameters. 
         * To perform an addition, two numbers are required. */
        static int Add(int x, int y)
        {
            return x + y;
        }

        //Does not have parameters but returns a greeting based on the time of the day.
        static string Greet()
        {
            string greeting = string.Empty;
      
            //DateTime.Now gives the current local date and time, for which we are comparing the hour.
            if(DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 12)
            {
                greeting = "Good morning!";
            }
            else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                greeting = "Good afternoon!";
            }
            else if(DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 21)
            {
                greeting = "Good evening!";
            } 
            else
            {
                greeting = "Good night!";
            }

            return greeting;
        }

        //Does not have parameters nor return type, thus the method returns nothing.
        static void SayHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        /* The main method is a special method because it is the entry point to our application.
         * Omitting the main method will cause a syntax error. */
        static void Main(string[] args)
        {
            /* In C#, there are two types of methods: built-in C# methods such as Main() and WriteLine(),
             * or user-defined method which the developer comes up with.
             * Methods promote code reusability. */

            int addResult = Add(42, 43);
            Console.WriteLine($"42 + 43 = {addResult}");
            Console.WriteLine($"23 + 29 = {Add(23,29)}");

            Console.WriteLine(Greet());

            SayHelloWorld(); //Call method to print Hello World to the console.

            Console.ReadLine();
        }
    }
}
