// ﻿namespace Task1
// {
//     class  workShop()
//     {
//         static void Main()
//         {
//             String userName = "Bijeta Maden";
//             int luckyNumber = 4;
//             Console.WriteLine($"Hello, {userName}! your lucky number is {luckyNumber}");
//         }
//     }
// }
//  class Circle
//     {
//         public const double PI = 3.14;

//         public static double CalculateArea(double radius)
//         {
//             return PI * radius * radius;
//         }

//         public static double CalculatePerimeter(double radius)
//         {
//             return 2 * PI * radius;
//     }
// }


// class Program
//    {
//     static void Main(string[] args)
//     {
//         double radius = 5;
//         double area = Circle.CalculateArea(radius);
//         double perimeter = Circle.CalculatePerimeter(radius);

//         Console.WriteLine($"Radius: {radius}");
//         Console.WriteLine($"Area: {area}");
//         Console.WriteLine($"Perimeter: {perimeter}");

//     }

// }

// namespace Task3
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             byte b = 10;
//             short s = 200;
//             int i = 1000;
//             long l = 50000;
//             float f = 3.14f;
//             double d = 25.67;
//             decimal dec = 123.45m;
//             char c = 'A';
//             bool flag = true;

//             int num = 42;
//             string str1 = num.ToString();

//             String str2 = "3.14";
//             double val = Convert.ToDouble(str2);

//             Console.WriteLine("Byte: " + b);
//             Console.WriteLine("Short: " + s);
//             Console.WriteLine("Int: " + i);
//             Console.WriteLine("Long: " + l);
//             Console.WriteLine("Float: " + f);
//             Console.WriteLine("Double: " + d);
//             Console.WriteLine("Decimal: " + dec);
//             Console.WriteLine("Char: " + c);
//             Console.WriteLine("Bool: " + flag);
//             Console.WriteLine("Converted int to String: " + str1);
//             Console.WriteLine("Converted String to double: " + val);

//         }
//     }
// }
// namespace Task_4
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = { 8, 3, 15, 1, 10 };


//             Console.WriteLine("Original Array:");
//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 Console.WriteLine(numbers[i]);
//             }
//             Array.Reverse(numbers);
//             Console.WriteLine("\nAfter Reversing:");
//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 Console.WriteLine(numbers[i]);
//             }
//             int searchNum = 10;
//             int index = Array.IndexOf(numbers, searchNum);

//             Console.WriteLine("\n\nPosition of " + searchNum + " in array: " + index);

//         }

//     }
// }

// namespace Task_5
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             List<String> fruits = new List<String>() { "Apple", "Banana", "Mango" };

//             fruits.Add("Papaya");

//             fruits.Remove("Banana");
//             Console.WriteLine("Fruits in the list:");
//             foreach (string fruit in fruits)
//             {
//                 Console.WriteLine(fruit);
//             }

//             Dictionary<int, string> fruitDict = new Dictionary<int, string>();
//             fruitDict.Add(1, "Apple");
//             fruitDict.Add(1, "Banana");
//             fruitDict.Add(1, "Orange");

//             fruitDict.Add(4, "Coconut");

//             Console.WriteLine("\nfruits in the dictionary:");
//             foreach (KeyValuePair<int, string> item in fruitDict)
//             {
//                 Console.WriteLine("ID:" + item.Key + ", Name:" + item.Value);
//             }
//         }
//     }
// }

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(2005, 6, 15);
            DateTime currentDate = DateTime.Now;

            TimeSpan ageSpan = currentDate - birthdate;
            int ageYears = (int)(ageSpan.Days / 365.25);

            Console.WriteLine("Birth Date: " + birthdate.ToShortDateString());
            Console.WriteLine("Current Date: " + currentDate);
            Console.WriteLine("Your Age: " + ageYears + "years");

            DateTime newDate = birthdate.AddDays(10);
            Console.WriteLine("Birth Date + 10 days: " + newDate.ToShortDateString());
        }
    }
}

