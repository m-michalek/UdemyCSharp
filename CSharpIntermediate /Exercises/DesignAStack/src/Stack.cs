using System;
using System.Collections;

namespace DesignAStack
{
    public class Stack
    {
        private ArrayList StackList = new ArrayList();

        public void Push(object obj)
        {
            object newStackItem = obj as object;

            if (newStackItem != null)
            {
                StackList.Insert(0, newStackItem);
            }
            else
            {
                throw new InvalidOperationException("Parameter has to be a type which derives from object class.");
            }
        }

        public object Pop()
        {
            if (StackList.Count <= 0)
                throw new InvalidOperationException("An item can't be removed from an empty stack.");
            
            var firstObject = StackList[0];
            
            StackList.RemoveAt(0);
            
            return firstObject;

        }

        public void Clear()
        {
            StackList.Clear();
        }

        public int Count()
        {
            return StackList.Count;
        }
    }
}