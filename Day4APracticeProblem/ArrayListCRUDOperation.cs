using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4APracticeProblem
{
    public class ArrayListCRUDOperation
    {
        public static void ArrayListMethod()
        {
            // Create an ArrayList
            ArrayList myList = new ArrayList();

            // Add items to the ArrayList
            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Orange");
            myList.Add("Mango");

            // Display the initial list
            Console.WriteLine("Initial List:");
            PrintList(myList);

            // CRUD Operations

            // Update an item at a specific index
            myList[2] = "Grapes";

            // Insert an item at a specific index
            myList.Insert(1, "Pineapple");

            // Remove an item at a specific index
            myList.RemoveAt(3);

            // Remove an item by value
            myList.Remove("Apple");

            // Display the modified list
            Console.WriteLine("\nModified List:");
            PrintList(myList);

            // Clear the ArrayList
            myList.Clear();

            // Display the empty list
            Console.WriteLine("\nEmpty List:");
            PrintList(myList);
        }

        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
