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

            Console.WriteLine("What is the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of this car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("ok!");
            }
            else
            {
                const int kmPerdemeritPoint = 5;
                var demeritPoint = (carSpeed-speedLimit) / kmPerdemeritPoint;
                if (demeritPoint > 12)
                {
                    Console.WriteLine("license suspended!");
                }
                else
                {
                    Console.WriteLine("demerit point is {0}", demeritPoint );
                }

            }



            
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
