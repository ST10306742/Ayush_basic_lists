using System;

namespace ListsRecape
{
    public class Program
    {
        static void Main(string[] args)
        {
            //recap of basic lists
            //ref: https://www.youtube.com/watch?v=vQzREQUhGSA - BroCode

            Console.WriteLine("Lists Recap Program");

            //decalre string list:
            List<string> names = new List<string>();

            //decalre int list:
            List<int> ages = new List<int>();

            //add items to the string list
            names.Add("Ayush");                 // 0
            names.Add("Jerry");                 // 1
            names.Add("Kayden");                // 2
            names.Add("Kiran");                 // 3
            names.Add("Mikey");                 // 4

            //add items to int list:
            ages.Add(20);                        // 0   
            ages.Add(20);                        // 1  
            ages.Add(21);                        // 2  
            ages.Add(21);                        // 3  
            ages.Add(20);                        // 4  

            //print full Lists before editing:
            Console.WriteLine("Names and Ages before editing:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}");
            }
            Console.WriteLine("\n");

            //Lists Commands:

            //Adding an element:
            names.Add("Jordan");
            ages.Add(22);

            //print full Lists after Add:
            Console.WriteLine("Names and Ages after adding Jordan:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}");
            }
            Console.WriteLine("\n");


            //Removing an element:
            ages.RemoveAt(names.IndexOf("Mikey")); //removes Mikey's age first before he gets deleted to avoid error
            names.Remove("Mikey");
            
            //print full Lists after Remove:
            Console.WriteLine("Names and Ages removing Mikey:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}");
            }
            Console.WriteLine("\n");


            //Insert at a given point:
            names.Insert(2, "Mikey");           //inserts at the 3rd space (0 - 1 - 2)
            ages.Insert(2, 20);

            //print full Lists after Inserting at index 2:
            Console.WriteLine("Names and Ages after adding Mikey back at index 2:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}");
            }
            Console.WriteLine("\n");

            //Count the amount of Items in a List:
            int ListAmount = names.Count; //both names and ages have the same amount(6)
            Console.WriteLine($"There are a total of {ListAmount} in the names and ages lists each.\n");
            Console.WriteLine("\n");


            //pulling an item's index: (like how when we pulled Mikey's age before removing him)

            Console.WriteLine($"Kayden's index in the names list is: {names.IndexOf("Kayden")}");
            //this should give a result of 3
            Console.WriteLine("\n");


            //Check if a Lists contains a specific item by returning a boolean
            // Test if the names list contains 'Jerry', should return true
            bool checkJerry = names.Contains("Jerry");

            //print result:
            if (checkJerry == true)
            {
                Console.WriteLine($"{checkJerry} - Jerry does exist in the names list"); //what should be returned
            }
            else
            {
                Console.WriteLine($"{checkJerry} - Jerry does not exist in the names list");
            }
            Console.WriteLine("\n");

            //Now test if John Cena is in the list (false because you can't see him.)
            bool checkJohnCena = names.Contains("John Cena");

            //print result:
            if (checkJohnCena == true)
            {
                Console.WriteLine($"{checkJohnCena} - John Cena does exist in the names list"); //what should be returned
            }
            else
            {
                Console.WriteLine($"{checkJohnCena} - YOU CAN'T SEE ME! ... in the list coz i don't exist.");
            }
            Console.WriteLine("\n");


            //sort the list, this time utlising the ages list

            //first sort in ascending order
            ages.Sort();

            //display ascending order (youngest to oldest)
            Console.WriteLine("ascending order (youngest to oldest)");
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine($"Age: {ages[i]}");
            }
            Console.WriteLine("\n");

            //now sort in descending order
            ages.Reverse();

            //display descending order (oldest to youngest)
            Console.WriteLine("descending order (oldest to youngest)");
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine($"Age: {ages[i]}");
            }
            Console.WriteLine("\n");

            //Clear your lists
            names.Clear();
            ages.Clear();
            Console.WriteLine("Both lists have been cleared");

            //Keep window opened:
            Console.ReadLine();
        }
    }
}