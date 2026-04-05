using System;
using System.Collections.Generic;




class UsingHashSet
{
    static void Main()
    {
        // Creating a HashSet of strings
        HashSet<string> fruits = new HashSet<string>();




        // Adding elements to the HashSet
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");


        // Trying to add a duplicate element
        fruits.Add("Apple"); // This will not be added
        fruits.Add("Apple"); // This will not be added
        fruits.Add("Apple"); // This will not be added


        // Displaying the elements in the HashSet
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        // Checking if "Apple" is in the HashSet
        if (fruits.Contains("Apple"))
        {
            Console.WriteLine("Apple is in the HashSet");
        }
        else
        {
            Console.WriteLine("Apple is not in the HashSet");
        }


        // Removing "Banana" from the HashSet
        fruits.Remove("Banana");

        Console.WriteLine("\nHashset Item Count after removing Banana = " + fruits.Count.ToString());
        // Displaying the remaining elements
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //this will remove all elements
        fruits.Clear();
        Console.WriteLine("\nHashset Item Count after clear = " + fruits.Count.ToString());


        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


        // Union of set1 and set2 (all unique elements from both sets)
        set1.UnionWith(set2);


        Console.WriteLine("Union of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }

        // Intersection of set1 and set2 (common elements)
        set1.IntersectWith(set2);


        Console.WriteLine("Intersection of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }

        // Removing elements of set2 from set1 (difference)
        set1.ExceptWith(set2);


        Console.WriteLine("Difference of sets (set1 - set2):");
        foreach (int item in set1)
        {
            Console.WriteLine(item); //result 1 2
        }

        //Retaining elements unique to each set using SymmetricExceptWith.
        // Symmetric difference between set1 and set2 
        set1.SymmetricExceptWith(set2);


        Console.WriteLine("Symmetric difference of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item); //result 1 2 4 5
        }


        HashSet<int> set10 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set20 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set30 = new HashSet<int> { 3, 4, 5 };

        // Checking if set1 and set2 are equal (same elements)
        Console.WriteLine("set1 equals set2: " + set10.SetEquals(set20)); //result true
        Console.WriteLine("set1 equals set3: " + set10.SetEquals(set30));//result false



        HashSet<int> set11 = new HashSet<int> { 1, 2 };
        HashSet<int> set22 = new HashSet<int> { 1, 2, 3, 4, 5 };

        // Checking if set1 is a subset of set2
        Console.WriteLine("set1 is a subset of set2: " + set11.IsSubsetOf(set22)); //result true
        Console.WriteLine("set2 is a subset of set1: " + set22.IsSubsetOf(set11)); //result false



        HashSet<int> set100 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set200 = new HashSet<int> { 2, 3 };

        // Checking if set1 is a superset of set2
        Console.WriteLine("set1 is a superset of set2: " + set100.IsSupersetOf(set200)); //result true


        HashSet<int> set01 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set02 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> set03 = new HashSet<int> { 6, 7, 8 };

        // Overlaps means that the two sets have at least one common element (ta9ato3)
        Console.WriteLine("set1 overlaps set2: " + set01.Overlaps(set02)); //result true because they have 3 in common
        Console.WriteLine("set1 overlaps set3: " + set01.Overlaps(set03)); //result false because they have no common elements






    }
}

