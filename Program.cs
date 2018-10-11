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
                from f in fruits
                where f.StartsWith("L")
                select f;

            Console.WriteLine("Here are the fruits that start with the letter L:");
            foreach (var item in queryResults)
                {

                    Console.WriteLine(item);
                }
            //sort names alphabetical using VAR to declare instead.

            var names = new List<string>()
                {
                    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina","Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice","Theodora", "William", "Svetlana", "Charisse", "Yolanda","Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    "Francisco", "Tre"
                };

            var sortedNames =
                    from n in names
                    orderby n
                    select n;


            Console.WriteLine("See Sorted list heyaaw:");
                foreach (var w in sortedNames)
                {
                    Console.WriteLine(w);
                }

                //build and sort descending

            List<int> numbers = new List<int>()
                {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
                var sortedNumbers =
                    from d in numbers
                    orderby d descending
                    select d;

            Console.WriteLine("The numbers from highest to lowest:");
                foreach (var d in sortedNumbers)
                {
                    Console.WriteLine(d);
                }


        }
    }
}
