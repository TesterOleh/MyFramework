using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsTask
{
    class Generics
    {
        static void Main(string[] args)
        {
            List<String> values = new List<String>(){ "5solar", "4solar", "NY", "3solar", "error" };
            List<String> searchResults = values.Where(s => s.Contains("solar")).ToList();

            searchResults = searchResults.Select(s => { s += "_winds";return s;}).ToList();

            searchResults.ForEach(Console.WriteLine);
            
            Console.ReadLine();
        }
    }
}
