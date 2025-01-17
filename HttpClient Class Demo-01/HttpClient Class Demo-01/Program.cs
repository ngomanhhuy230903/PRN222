﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient_Class_Demo_01
{
    class Program
    {
        // HttpClient is intended to be instantiated once per application.
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            string uri = "http://www.contoso.com/";

            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
