using System;

namespace DataStructures_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables and Objects
            int Min = 0;
            int Max = 100;
            int[] stackArray = new int[20];
            StackController stackController = new StackController();
            Random randNum = new Random();

            // Assigning random values into the Stack Array
            for (int i = 0; i < stackArray.Length; i++) 
            {
                stackArray[i] = randNum.Next(Min, Max);
            }

            // Pushing values onto the Stack
            for (int i = 0; i < stackArray.Length; i++)
                stackController.Push(stackArray[i]);
            // Popping values off of the Stack
            for (int i = stackArray.Length - 1; i >= 0; i--)
                stackController.Pop();

            // Checks whether these values are contained in the array
            stackController.Contains(6);
            stackController.Contains(27);

            // Access Object in Stack
            stackController.Access(15);
           

            Console.ReadKey();
        }
    }
}
