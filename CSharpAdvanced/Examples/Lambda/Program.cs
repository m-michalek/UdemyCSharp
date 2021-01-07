using System;

namespace Lambda
{
    class Program
    {
        // Pointer for a function
        public delegate void Print(string text); 
        
        static void Main(string[] args)
        {
            // Lambda/anonymous method gets assigned to delegate/pointer 
            void Print(string text) => Console.WriteLine(text);


            // Alternative:
            // Action<string> EasyPrint = (string text) => Console.WriteLine(text);
            void EasyPrint(string text) => Console.WriteLine(text);

            // Lambda gets executed
            Print("Hello World!");
            EasyPrint("EasyPrint was easier to implement...");
        }
    }
}