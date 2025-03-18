using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stakcs in collection is available in two flavour both genric and non generic 
            //down writtn code more for genric ...whic is numberStack
            // LIFO last in first out 

            Stack nongeneric = new Stack();// ican write non genric also here 
            nongeneric.Push(1);
            nongeneric.Push("abc");

            // Create a stack of integers
            Stack<int> numberStack = new Stack<int>();


            // Push elements onto the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);
            numberStack.Push(40);

            // Print the elements in the stack
            Console.WriteLine("Elements in the stack:");
            foreach (int num in numberStack)
            {
                Console.WriteLine(num);
            }

            // Pop elements from the stack it will remove the value 
            int poppedElement = numberStack.Pop();
            Console.WriteLine("Popped element: " + poppedElement);

            // Peek at the top element without removing it
            int topElement = numberStack.Peek();
            Console.WriteLine("Top element: " + topElement);

            // Print the updated stack
            Console.WriteLine("Remaining elements in the stack:");
            foreach (int num in numberStack)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        
}
    }
}
