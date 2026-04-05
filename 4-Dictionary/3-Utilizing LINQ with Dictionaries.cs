using System;
using System.Collections.Generic;
using System.Linq;


class utilizingLINQWithDictionaries
{
    void Example()
    {
        // Creating and initializing the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


        // Using LINQ to transform items
        var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value });


        // Displaying the results
        Console.WriteLine("Transformed Items:");
        foreach (var item in fruitInfo)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }




        // Using LINQ to filter items
        var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);


        Console.WriteLine("\nFiltered Items >3:");
        foreach (var item in filteredFruit)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }



        // Using LINQ to sort by value
        var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);


        Console.WriteLine("\nSorted Items:");
        foreach (var item in sortedByQuantity)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }


        // Using LINQ to sort by value
        var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);


        Console.WriteLine("\nSorted Items Desc:");
        foreach (var item in sortedByQuantityDesc)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Using LINQ to aggregate data
        int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);

        Console.WriteLine($"\nTotal Quantity: {totalQuantity}");


        // Dictionary for grouping
        Dictionary<string, string> fruitsCategory = new Dictionary<string, string>
        {
            { "Apple", "Tree" },
            { "Banana", "Herb" },
            { "Cherry", "Tree" },
            { "Strawberry", "Bush" },
            { "Raspberry", "Bush" }
        };


        // Grouping fruits by category
        var groupedFruits = fruitsCategory.GroupBy(kpv => kpv.Value);
        foreach (var group in groupedFruits)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var fruit in group)
            {
                Console.WriteLine($" - {fruit.Key}");
            }
        }


        // Another Dictionary for combined queries
        Dictionary<string, int> fruitBasket2 = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


        // Combined LINQ queries
        var sortedFilteredFruits = fruitBasket2
            .Where(kpv => kpv.Value > 3)
            .OrderBy(kpv => kpv.Key)
            .Select(kpv => new { kpv.Key, kpv.Value });

        Console.WriteLine("\nSorted and Filtered Fruits:");
        foreach (var fruit in sortedFilteredFruits)
        {
            Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
        }

    }
}
