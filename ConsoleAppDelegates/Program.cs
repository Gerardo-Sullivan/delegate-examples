using System;

namespace ConsoleAppDelegates
{
    /// <summary>
    /// Program class to run code
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DelegateMethods.Del handler = DelegateMethods.DelMethod;
            handler("Hello World."); // Prints 'Hello World'
            DelegateMethods.MethodWithCallback(1, 2, handler); // prints 'The number is: 3
            Console.WriteLine();

            // Usings the greetings class to handle different greetings using delegates
            Console.WriteLine("Greetings!");
            Console.WriteLine();
            Greetings obj = new Greetings();
            DelegateMethods.Del d1 = obj.English;
            DelegateMethods.Del d2 = obj.Spanish;
            DelegateMethods.Del d3 = obj.German;

            DelegateMethods.Del worldGreetings;
            worldGreetings = d1 + d2 + d3;

            worldGreetings("Gerardo");


            Console.WriteLine();
            Console.WriteLine("Press any enter to exit...");
            Console.ReadLine();
        }
    }
}
