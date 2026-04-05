using System;
using System.Collections.Generic;
using System.Linq;


internal class List
{
    void Example()
    {
        // Creating a new List of integers
        List<int> numbers = new List<int>();

        // Adding elements to the list
        numbers.Add(1); // Add 1 to the list

        // Displaying the total number of elements in the list
        Console.WriteLine("Number of items in the list: " + numbers.Count);

        // Accessing and displaying each element in the list
        Console.WriteLine(numbers[0]); // Displays the first element (1)

        // Modifying an element in the list
        Console.WriteLine("Changing the value of item 2 of the list to 500:");
        numbers[1] = 500; // Change the value of the second element to 500
        Console.WriteLine(numbers[1]); // Displays the new value of the second element (500)

    }

    void CRUD()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        // Adding an element at the end
        numbers.Add(11);
        Console.WriteLine("After adding 11: " + string.Join(", ", numbers));


        // Inserting an element at a specific position
        numbers.Insert(0, 0);
        Console.WriteLine("After inserting 0 at the beginning: " + string.Join(", ", numbers));


        // Inserting multiple elements
        numbers.InsertRange(5, new List<int> { 55, 56 });
        Console.WriteLine("After inserting 55 and 56 at index 5: " + string.Join(", ", numbers));

        // Removing an Item by Value
        numbers.Remove(5);

        // Removing an Item by Index
        numbers.RemoveAt(0);

        // Removing Multiple Items
        numbers.RemoveAll(n => n % 2 == 0);

        // Clearing the List
        numbers.Clear();

    }

    void Looping()
    {
        // Full Code with Looping Examples
        // Creating and initializing a List of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };


        // Displaying the total number of elements in the list
        Console.WriteLine("Number of items in the list: " + numbers.Count);


        // Looping through the list using a for loop
        Console.WriteLine("\nDisplaying list elements using a for loop:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]); // Accessing each element by its index
        }


        // Looping through the list using a foreach loop
        Console.WriteLine("\nDisplaying list elements using a foreach loop:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number); // Accessing each element directly
        }


        // Looping through the list using the List.ForEach method
        Console.WriteLine("\nDisplaying list elements using List.ForEach:");
        numbers.ForEach(number => Console.WriteLine(number)); // Using a lambda expression

    }

    void Aggregation()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Aggregation operations
        Console.WriteLine("Sum: " + numbers.Sum());
        Console.WriteLine("Average: " + numbers.Average());
        Console.WriteLine("Minimum: " + numbers.Min());
        Console.WriteLine("Maximum: " + numbers.Max());
        Console.WriteLine("Count: " + numbers.Count());
    }
    void Filtering()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        // LINQ Filtering
        Console.WriteLine("Even Numbers: " + string.Join(", ", numbers.Where(n => n % 2 == 0)));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", numbers.Where(n => n % 2 != 0)));
        Console.WriteLine("Numbers Greater Than 5: " + string.Join(", ", numbers.Where(n => n > 5)));
        Console.WriteLine("Every Second Number: " + string.Join(", ", numbers.Where((n, index) => index % 2 == 1)));
        Console.WriteLine("Numbers Between 3 and 8: " + string.Join(", ", numbers.Where(n => n > 3 && n < 8)));


    }
    void Sorting()
    {
        // List initialization
        List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };


        // Default Sorting (Ascending)
        numbers.Sort();
        Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", numbers));


        // Sorting in Descending Order
        numbers.Reverse();
        Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));


        // Sorting with LINQ
        Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", numbers.OrderBy(n => n)));
        Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));

    }
    void OtherMethodsWithNumber()
    {
        // List initialization
        List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };


        // Using Contains
        Console.WriteLine("List contains 9: " + numbers.Contains(9));


        // Using Exists
        Console.WriteLine("List contains negative numbers: " + numbers.Exists(n => n < 0));


        // Using Find
        Console.WriteLine("First negative number: " + numbers.Find(n => n < 0));


        // Using FindAll
        Console.WriteLine("All negative numbers: " + string.Join(", ", numbers.FindAll(n => n < 0)));


        // Using Any
        Console.WriteLine("Any numbers greater than 100: " + numbers.Any(n => n > 100));

    }
    void OtherMethodsWithString()
    {
        // List initialization
        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };


        // Using Contains
        Console.WriteLine("List contains 'apple': " + words.Contains("apple"));


        // Using Exists
        Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length == 5));


        // Using Find
        Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));


        // Using FindAll
        Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", words.FindAll(word => word.Length > 5)));


        // Using Any
        Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));

    }
    void Converting()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        // Converting the list to an array
        int[] numbersArray = numbers.ToArray();


        // Displaying the array elements
        Console.WriteLine("Array elements: " + string.Join(", ", numbersArray));

        int[] numbersArray2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Converting the array to a list
        List<int> numbersList = new List<int>(numbersArray2);

    }
}

