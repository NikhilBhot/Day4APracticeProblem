using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4APracticeProblem
{
    public class DictionaryCRUDOpearion
    {
        public static void DictionaryCRUDOperationMethod()
        {
            // Create a Dictionary
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            // Add items to the Dictionary
            myDictionary.Add(1, "Apple");
            myDictionary.Add(2, "Banana");
            myDictionary.Add(3, "Orange");
            myDictionary.Add(4, "Mango");

            // Display the initial dictionary
            Console.WriteLine("Initial Dictionary:");
            PrintDictionary(myDictionary);

            // CRUD Operations

            // Read an item from the Dictionary
            string fruit = myDictionary[2];
            Console.WriteLine("\nValue at key 2: " + fruit);

            // Update an item in the Dictionary
            myDictionary[3] = "Grapes";

            // Remove an item from the Dictionary
            myDictionary.Remove(1);

            // Display the modified dictionary
            Console.WriteLine("\nModified Dictionary:");
            PrintDictionary(myDictionary);

            // Clear the Dictionary
            myDictionary.Clear();

            // Display the empty dictionary
            Console.WriteLine("\nEmpty Dictionary:");
            PrintDictionary(myDictionary);
        }

        static void PrintDictionary(Dictionary<int, string> dictionary)
        {
            foreach (var pair in dictionary)
            {
                Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
            }
        }
    }
}
