using System;

namespace Fizzbuzz
{
    public class Conditional
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 100; i++)
            //{
            //    string results = "";
            //    if (i % 3 == 0) results = "Fizz";

            //    if (i % 5 == 0) results = results + "Buzz";

            //    if (results.Length == 0) results = i.ToString();
            //    Console.WriteLine(results);
            //}

            //Console.WriteLine("Enter a number between 1 to 10");
            //var input = Console.ReadLine();
            //var number = Convert.ToInt32(input);
            //if(number >= 1 && number <= 10)
            //{
            //    Console.WriteLine("Valid!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid!");
            //}

            //Console.WriteLine("Enter a number:");
            //var number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter another number:");
            //var number2 = Convert.ToInt32(Console.ReadLine());

            //if(number1 > number2)
            //{
            //    Console.WriteLine("The max is {0}", number1);
            //}

            //else
            //{
            //    Console.WriteLine("The max is {0}", number2);
            //}

            //Console.WriteLine("Image width:");
            //var width = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Image hight:");
            //var hight = Convert.ToInt32(Console.ReadLine());

            //var orientation = (width > hight) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            //Console.WriteLine("Image orientation is {0}", orientation);

            // speed limit; speed of the car; km per demerit point= 5; if the number of demerit point is above 12, license suspended.

            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //var name = "Jone Smith";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int[] { 1,2,3,4};
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (!string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }

            //    break;

            //}

            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer); 
            Console.WriteLine(password);


            


        }

 
    }
}
