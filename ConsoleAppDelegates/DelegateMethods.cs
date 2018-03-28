using System;

namespace ConsoleAppDelegates
{
    /// <summary>
    /// Delegate class used to create and handle delegates
    /// </summary>
    public class DelegateMethods
    {
        /// <summary>
        /// Delegate used to print a simple message to console
        /// </summary>
        /// <param name="message"></param>
        public delegate void Del(string message);

        /// <summary>
        /// Basic method definition for printing to console
        /// </summary>
        /// <param name="message">Simple message</param>
        public static void DelMethod(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1">Number 1</param>
        /// <param name="param2">Number 2</param>
        /// <param name="callback">Delegate used to print to console</param>
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback($"The number is: {param1 + param2}");
        }
    }
}
