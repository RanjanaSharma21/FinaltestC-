// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;


//Generic class based on value type
public class GenericCollection<T> where T : struct
{
    // private generic collection
    private List<T> items;    

    public GenericCollection()
    {
        items = new List<T>();
    }


    // method to add items
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // return an item from the list
    public T GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }

    //sorting the list
    public List<T> GetSortedDescending()
    {
        return items.OrderByDescending(i => i).ToList();
       
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        var intCollection = new GenericCollection<int>();
        intCollection.AddItem(7);
        intCollection.AddItem(71);
        intCollection.AddItem(65);

        Console.WriteLine("Original Collection:");
        foreach (var item in intCollection.GetSortedDescending())
        {
            Console.WriteLine(item);
        }

        int itemAtIndex = intCollection.GetItem(1);
        Console.WriteLine($"Item at index 1: {itemAtIndex}");
    }
}