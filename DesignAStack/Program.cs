using System;

namespace DesignAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();
                
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                
                stack.Clear();

                Console.WriteLine(stack.Count());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}