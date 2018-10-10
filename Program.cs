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
        }
    }
}
