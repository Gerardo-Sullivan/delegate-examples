using System;

namespace ConsoleAppDelegates
{
    class Program
    {
        public delegate void Del(string message);
        static void Main(string[] args)
        {
            Del handler = DelegateMethod.DelMethod;
            handler("Hello World.");
        }
    }
}
