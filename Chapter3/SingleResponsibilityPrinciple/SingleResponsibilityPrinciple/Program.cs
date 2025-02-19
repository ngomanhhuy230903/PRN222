using System;
using System.IO;
using Newtonsoft.Json;
using SingleResponsibilityPrinciple.Model;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Books");
            Console.WriteLine("-----------------------------");

            var cadJSON = File.ReadAllText("G:\\Ki_7\\SingleResponsibilityPrinciple\\SingleResponsibilityPrinciple\\Data\\BookStore.json"); //nguồn file json
            var bookList = JsonConvert.DeserializeObject<Book[]>(cadJSON);

            foreach (var item in bookList)
            {
                Console.WriteLine($"{item.Title.PadRight(39, ' ')} " + 
                    $"{item.Author.PadRight(15, ' ')} {item.Price}");
            }

            Console.Read();
        }
    }
}
