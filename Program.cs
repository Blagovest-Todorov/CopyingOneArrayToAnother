using System;

namespace LearnLectures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oldArray = new int[4];
            int[] newArray = new int[]{1,2,3,4,5};


            Console.WriteLine("We print OLD ARRAY");
            foreach (var item in oldArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Print New Array");
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("now we copy elements from old array into the newArray and print the elements of newArray");

            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
                Console.WriteLine(newArray[i]);
            }

            Console.WriteLine("Now we print the changed newARR");
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
