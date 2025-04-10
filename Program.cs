using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods_shepardson_bruce
{
    // Define the Program class
    internal class Program
    {
        // Main entry point of the program
        static void Main(string[] args)
        {
            // Prompt the user to enter a whole number
            Console.WriteLine("please enter a whole number");
            // Convert the input to an integer and store it in the variable 'x'
            int x = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter another whole number
            Console.WriteLine("please enter another number");
            // Convert the second input to an integer and store it in the variable 'y'
            int y = Convert.ToInt32(Console.ReadLine());

            // Call the Multiply method to multiply 'x' and 'y', and display the result
            Console.WriteLine(Multiply(x, y));

            // Ask for the user's name
            Console.WriteLine("what is your name?");
            // Read the user's input (their name) and store it in the 'name' variable
            string name = Console.ReadLine();

            // Call the WelcomeUser method to greet the user with their name
            WelcomeUser(name);
        }

        // A method that multiplies two integers and returns the result
        static int Multiply(int x, int y)
        {
            // Return the product of 'x' and 'y'
            return x * y;
        }

        // A method that welcomes the user with their name
        static void WelcomeUser(string username)
        {
            // Display a personalized greeting message
            Console.WriteLine($"hello, {username} it is nice to meet you");
        }

        // A method that says goodbye (currently not called in the program)
        static void Goodbye()
        {
            // Display a goodbye message
            Console.WriteLine("have a nice day");
        }
    }
}
