using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceSegregationPrinciple.Utilities;
using InterfaceSegregationPrinciple.Model;

class Program
{
    static List<Video> bookList;

    static void PrintBooks(List<Video> books)
    {
        Console.WriteLine("List of Books");
        Console.WriteLine("------------");

        foreach (var item in books)
        {
            Console.WriteLine($"{item.Title.PadRight(36, ' ')} " +
                              $"{item.Author.PadRight(20, ' ')} {item.Price} " +
                              $"{(item.Topic != null ? item.Topic.PadRight(12, ' ') : "")} " +
                              $"{(item.Duration ?? "")}");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        string id = string.Empty;
        Console.Title = "Interface Segregation Principle Demo";

        do
        {
            Console.Write("File no. to read: 1/2/3 - Enter to exit: ");
            id = Console.ReadLine();

            if ("123".Contains(id) && !string.IsNullOrEmpty(id))
            {
                bookList = Utilities.ReadData(id);
                PrintBooks(bookList);
            }
        } while (!string.IsNullOrWhiteSpace(id));
    }
}
