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

            //var random = new Random();

            //const int passwordLength = 10;

            //var buffer = new char[passwordLength];
            //for (var i = 0; i < passwordLength; i++)
            //    buffer[i] = (char)('a' + random.Next(0, 26));
            //var password = new string(buffer); 
            //Console.WriteLine(password);

            //var count = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //   if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //    Console.WriteLine("There are {0} numbers are divisible by 3 with no remainder.", count);
            //}

            //var sum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number (or 'ok' to exit):");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //    { break; }
            //    else
            //    {
            //        sum += Convert.ToInt32(input);
            //    }
            //}
            //Console.WriteLine("Sum of all number is {0}:", sum);



            //Console.WriteLine("Enter a number:");

            //var number = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for (int i = 1; i < number; i++)
            //{
            //    factorial = factorial * i;
            //}

            //Console.WriteLine("{0}! = {1}", number, factorial);



            //int secretNumber = new Random().Next(1, 10);
            //Console.WriteLine("Secret number is {0}", secretNumber);

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Please guess the number:");
            //    var input = Convert.ToInt32(Console.ReadLine());
            //    if (input == secretNumber)
            //    {
            //        Console.WriteLine("You won!");
            //        return;
            //    }
            //    Console.WriteLine("You lost!");
            //}

            Console.WriteLine("Please enter a series of numbers seperated by comma:");

            var input = Console.ReadLine();
            var number = input.Split(',');

            var max = Convert.ToInt32(number[0]);

            foreach (var item in number)
            {
                var numbers = Convert.ToInt32(item);
                if (numbers > max)
                {
                    max = numbers;
                }
            }
            Console.WriteLine("The maximum of the numbers is {0}", max);
        }
    }
}