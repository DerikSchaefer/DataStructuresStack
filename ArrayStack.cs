using System;

namespace DSA
{
    class ArrayStack
    {

        private int[] stackArray;

        private int top;

        // Creating 10 element stack array, empty so value
        // of top is -1
        public ArrayStack()
        {
            stackArray = new int[10];
            top = -1;
        }

        public ArrayStack(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        // returns true if stack is empty, it is empty if the
        // value of top is -1
        public bool IsEmpty()
        {
            return (top == -1);
        }

        // returns true if top is equal to the last index of
        // stack 
        public bool isFull()
        {
            return (top == stackArray.Length - 1);
        }

        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack overflow");
                return;
            }

            top = top + 1;
            stackArray[top] = x;
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack underflow");
            }
            x = stackArray[top];
            top = top - 1;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack underflow");
            }
            return stackArray[top];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Stack is : ");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}