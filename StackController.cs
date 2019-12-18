using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Stack
{
    public class StackController
    {

        public Stack newStack = new Stack();
        public int count = 0;
        public int x;
        public bool found;

        public void Push(int nextInt) 
        {
            count++;
            
            newStack.Push(nextInt);
        }

        public int Pop() 
        {
            --count;
            x = (int)newStack.Pop();


            if (count == 0)
            {
                Console.Write(x + ".");
            }
            else
            {
                Console.Write(x + ", ");
            }
            return x;
        }

        public bool Contains(int intFound) 
        {
            found = false;
            if (newStack.Contains(intFound)) 
            {
                found = true;
                Console.Write("Target Hit!");
            }
            
            return found;
        }

        public int Access(int intFound) 
        {
            while (count > 0) 
            {
                if (intFound.Equals(x)) 
                {
                    return x;
                }
                throw new NullReferenceException("Object not found" + intFound);
            }

            return intFound;
        }

        public int Count() 
        {
            Console.WriteLine("Count: ");
            return count;
        }
    }
}
