using System;

namespace BinarySearch
{
    // Binary searching can only be used with sorted data
    // to find the middle we can do this (start + end)/2 = middle
    // Psuedo Code: 
    // Step 1 : Choose the element in the middle of array and compare it against the search value
    // Step 2 : if they eqaul then you are done.
    // Step 3 : If item we are looking for is lower than the middle item, we know that the lower half of the list (and the middle can be 
    //          elelminated.)
    // Step 4 : If item we are looking for is greater than the middle item, we know that the upper half of the list (and the middle can be 
    //          elelminated.)

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { -20, -15, 2, 7, 20, 30, 54 };
            Console.WriteLine("Enter value to be searched");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine(Search(intArray,value));
           
        }

       public  static int Search(int[] intArray, int value)
        {
            int start = 0;
            int end = intArray.Length;

            // start + while less tham is going to do criss crossing
           while(start < end)
            {
               
                int middle = (start + end) / 2;

                // Search for the middle
                if(intArray[middle] == value)
                {
                    return middle;
                }
                else if(intArray[middle] < value)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle;
                }

            }
            return -1;
        }
    }
}
