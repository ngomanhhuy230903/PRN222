using Newtonsoft.Json;
using OpenClosedPrinciple.Model;
using System.Collections.Generic;
using System.IO;

internal class Utilities
{
    // Sửa cú pháp của phương thức ReadFile
    internal static string ReadFile(string filename)
    {
        return File.ReadAllText(filename);
    }

    // Đọc dữ liệu từ file BookStore_01.json
    internal static List<Book> ReadData()
    {
        var cadJSON = ReadFile("G:\\Ki_7\\PRN222\\Chapter3\\OpenClosedPrinciple\\OpenClosedPrinciple\\Data\\BookStore_01.json");
        return JsonConvert.DeserializeObject<List<Book>>(cadJSON);
    }

    // Đọc dữ liệu từ cả hai file và kết hợp chúng
    internal static List<Book> ReadDataExtra()
    {
        List<Book> books = ReadData(); // Đọc dữ liệu từ BookStore_01.json
        var cadJSON = ReadFile("G:\\Ki_7\\PRN222\\Chapter3\\OpenClosedPrinciple\\OpenClosedPrinciple\\Data\\BookStore_02.json"); // Đọc dữ liệu từ BookStore_02.json
        books.AddRange(JsonConvert.DeserializeObject<List<Book>>(cadJSON)); // Kết hợp dữ liệu từ BookStore_02.json
        return books;
    }
}
