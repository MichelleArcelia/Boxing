using System;
using System.Collections.Generic;

namespace Boxing {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("BoxingUnboxing!");

//Create an empty List of type object
            List<object> myList = new List<object> ();


//Add the following values to the list: 7, 28, -1, true, "chair"
            myList.Add (7);
            myList.Add (28);
            myList.Add (-1);
            myList.Add (true);
            myList.Add ("chair");

//Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (var item in myList) {
                Console.WriteLine (item);
            }


//Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (var item in myList) {
                if (item is int) {

                    sum = sum + Convert.ToInt32(item);  // OR sum = sum + (int)item;
                }
            }
            Console.WriteLine ("This is the sum of the integers added together:");
            Console.WriteLine (sum);
        }
    }
}