using System;

namespace StringHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            char letterA = 'A'; //Char values are to be wrapped in single quotes and allow only one character at a time.

            /* A string is a data type allowing a mixture of letters, numbers, and symbols.
             * Whilst a char is able to handle any character, it only allows one character at a time.
             * Furthermore, string values must be wrapped within double quotes,
             * whereas char values must be wrapped within single quotes. */

            /* You should always refrain from comparing strings with == as in reality you would be comparing the addresses of the strings in memory. 
             * To compare the values, always use the Equals() method. */

            Console.Write("Email address: ");
            string emailAddress = Console.ReadLine(); //Ask the user for an email address and store it in a string variable.
            
            //Check if the user has supplied an email address.
            if(string.IsNullOrEmpty(emailAddress)) //or... emailAddress.Equals(string.Empty)
            {
                //If the user does not provide an email address, issue an error.
                Console.ForegroundColor = ConsoleColor.Red; //Change the text colour to red to indicate an error has occurred.
                Console.WriteLine("Enter a valid email address!");
            } 
            else
            {
                //If the user provides a valid email address, display a message and thank them.
                Console.ForegroundColor = ConsoleColor.Green; //Change the text colour to green to indicate that the user has supplied a valid email address.
                Console.WriteLine($"You have entered {emailAddress}. Thank you for signing up!");
            }

            Console.ResetColor(); //Change the text colour to what it was before.

            string name = "Mandy";

            Console.WriteLine($"Original: {name}\tLowercase: {name.ToLower()}");
            Console.WriteLine($"Original: {name}\tUppercase: {name.ToUpper()}");
            Console.WriteLine($"Original: {name}\tTrimmed: {name.Trim()}");

            /* Remember that C# is case-sensitive, thus a lowercase character is not equal to its uppercase equivalent.
             * This is because the binary codes of both equivalents differ from one another. */
            Console.WriteLine($"Does the name {name} end with dy?: {name.EndsWith("dy")}");
            Console.WriteLine($"Does the name {name} end with ne?: {name.EndsWith("ne")}");
            Console.WriteLine($"Does the name {name} start with M?: {name.StartsWith("M")}");
            Console.WriteLine($"Does the name {name} contain the letter a?: {name.Contains("a")}");

            /* Length gives us the number of characters which make up a string.
             * Remember that spaces also count as characters. */
            Console.WriteLine($"How many letters long is the name {name}?: {name.Length}");

            Console.ReadLine(); //Pause the program until the Enter key is pressed - this gives the user time to view the output.
        }
    }
}