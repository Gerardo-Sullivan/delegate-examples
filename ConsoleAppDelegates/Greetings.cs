using System;

namespace ConsoleAppDelegates
{
    /// <summary>
    /// Greetings class containing greetings from three different languages
    /// Used to learn and play around with delegates
    /// </summary>
    public class Greetings
    {
        /// <summary>
        /// English gretting
        /// </summary>
        /// <param name="name">Name of greeted person</param>
        public void English(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        /// <summary>
        /// Spanish greeting
        /// </summary>
        /// <param name="name">Name of greeted person</param>
        public void Spanish(string name)
        {
            Console.WriteLine("Hola " + name);
        }

        /// <summary>
        /// German greeting
        /// </summary>
        /// <param name="name">Name of greeted person</param>
        public void German(string name)
        {
            Console.WriteLine("Hallo " + name);
        }
    }
}
