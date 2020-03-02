using System;
using System.Collections.Generic;

namespace Fizzbuzz
{
    public class Conditional
    {
        static void Main(string[] args)
        {
            //var numbers = new [] { 3, 7, 9, 2, 14, 6 };

            ////Length
            //Console.WriteLine("Length: " + numbers.Length);

            //// IndexOf()

            //var index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("Index of 9: " + index);

            //// Clear
            //Array.Clear(numbers, 0, 2);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //// Copy
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);

            //Console.WriteLine("Effect of Copy()");
            //foreach (var n in another)
            //{
            //    Console.WriteLine(n);
            //}

            //// Sort method
            //Array.Sort(numbers);
            //Console.WriteLine("Effect of Sort()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //// Reverse()
            //Array.Reverse(numbers);
            //Console.WriteLine("Effect of Reverse()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //var ha = new List<int>() {1, 2, 3, 4};
            //ha.Add(1);
            //ha.AddRange(new int[3] { 5, 6, 7 });
            //foreach (var item in ha)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Index of 1: ", ha.IndexOf(1));


            //Console.WriteLine();


            // Exercise 1
            //var names = new List<string>();

            //while(true)
            //{
            //    Console.WriteLine("Type a new (or hit enter to quit): ");

            //    var input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input))
            //        break;
            //    names.Add(input);
            //}

            //if(names.Count > 2)
            //    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            //else if (names.Count == 2)
            //    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            //else if (names.Count == 1)
            //    Console.WriteLine("{0} likes your post", names[0]);
            //else
            //    Console.WriteLine();

            // Exercise 2 
            //Console.Write("What's your name");
            //var name = Console.ReadLine();

            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //var reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);

            /*Exercise 3
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You have previously entered" + number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number); */

            //Exercise 4
            /*var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to exist): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            uniques.Sort();

            Console.WriteLine("Unique numbers:");
            foreach(var number in uniques)
            {
                Console.WriteLine(number);
            } */


            /*var dataTime = new DateTime(2020, 01, 03);
            var now = DateTime.Now;

            Console.WriteLine("Hour:" + now.Hour);
            Console.WriteLine("Minute:" + now.Minute);
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); */

            //var timespan = new TimeSpan(1, 2, 3);
            //var tmespan1 = new TimeSpan(1, 0, 0);

            //TimeSpan.FromHours(1);



            /*var fullName = "April He";

            Console.WriteLine("Trime: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("Firstname: " + names[0]);
            Console.WriteLine("Lastname: " + names[1]);

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            } */

            var sentence = "This is going to be a really really long text";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
  
            
        }

       
    }
}