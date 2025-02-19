using OpenClosedPrinciple.Model;
using System;
using System.Collections.Generic;

internal class Program
{
    static List<Book> bookList;

    // Phương thức in danh sách sách
    static void PrintBooks(List<Book> books)
    {
        Console.WriteLine("List of Books");
        Console.WriteLine("-------------");

        foreach (var item in books)
        {
            Console.WriteLine($"{item.Title.PadRight(39, ' ')} {item.Author.PadRight(20, ' ')} {item.Price}");
        }

        Console.ReadLine(); // Đảm bảo chương trình dừng lại khi in ra
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, press 'yes' to read an extra file,");
        Console.WriteLine("or any other key for a single file");

        var ans = Console.ReadLine();

        // Đọc dữ liệu từ file
        bookList = (ans.ToLower() == "yes") ? Utilities.ReadDataExtra() : Utilities.ReadData();

        // In ra danh sách sách
        PrintBooks(bookList);
    }
}
