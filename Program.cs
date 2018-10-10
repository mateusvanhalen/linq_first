using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {
        public string fruits {get; set;}
        static void Main()
        {

            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};
            fruits.ForEach(fru => Console.WriteLine(fru));




            // please notate this is how you console write a list
            //also note this is how you console write first letter

            var queryResults =
                from n in fruits
                where n.StartsWith("L")
                select n;

            foreach (var item in queryResults)
                {
                    Console.WriteLine(item);
                }
            // List<int> numbers = new List<int>()
            //     {
            //         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //     };

            // IEnumerable<int> fourSixMultiples = numbers.Where();


        }
    }
}
