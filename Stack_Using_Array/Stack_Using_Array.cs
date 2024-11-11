using System;

namespace Stack_Using_Array
{
    public class StackArray
    {
        private int[] stack;
        private int top;
        private int maxSize;

        public StackArray(int size)
        {
            maxSize = size;
            stack = new int[maxSize];
            top = -1;
        }

        public void Push(int value)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                stack[++top] = value;
                Console.WriteLine($"Pushed {value} to stack");
            }
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
                return stack[top--];
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
                return stack[top];
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
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

                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

    class Stack_Using_Array
    {
        static void Main()
        {
            StackArray stack = new StackArray(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Display();

            Console.WriteLine($"Top element is: {stack.Peek()}");

            Console.WriteLine($"Popped element is: {stack.Pop()}");
            stack.Display();
        }
    }

}
