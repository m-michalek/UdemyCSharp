using System;

namespace MethodExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello World!";

            // Microsoft recommends to only use method extension if there is no other way...
            // Try to avoid them, they can lead to unexpected behavior if the extended method gets added to the class
            // at some time later.
            text.Print();
            text.PrintWithEmoji("👌");
        }
    }

    public static class StringExtensions
    {
        public static void Print(this string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintWithEmoji(this string text, string emoji)
        {
            Console.WriteLine($"{text} {emoji}");
        }
    }
}