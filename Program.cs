using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    public class Program
    {
        public string fruits {get; set;}
        public List<Bank> Banks { get; set;}
        public List<Bank> banks { get; set; }

        public class Bank

            {
            public string Symbol { get; set; }
            public string Name { get; set; }
            }

        public class Customer
            {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
            }

        public static void Main() {

            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},

            };

             List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            // List<ReportItem> millionaireReport = new List<ReportItem>() {
            //         from m in Customer.Balance
            //         where m > 10000000
            //         select m;

            // Console.WriteLine("Here is a list of millionaires");
            //     foreach (var m in millionaireReport)
            //     {
            //         Console.WriteLine(m);
            //     }



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
}
