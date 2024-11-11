using System;
using System.Collections.Generic;

namespace Stack_Using_List
{
    public class StackList
    {
        private List<int> stack;

        public StackList()
        {
            stack = new List<int>();
        }

        public void Push(int value)
        {
            stack.Add(value);
            Console.WriteLine($"Pushed {value} to stack");
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                int value = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return value;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                return stack[stack.Count - 1];
            }
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack elements:");

                for (int i = stack.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
    internal class Stack_Using_List
    {
        static void Main(string[] args)
        {
            StackList stack = new StackList();

            stack.Push(15);
            stack.Push(25);
            stack.Push(35);
            stack.Display();

            Console.WriteLine($"Top element is: {stack.Peek()}");

            Console.WriteLine($"Popped element is: {stack.Pop()}");
            stack.Display();
        }
    }
}
