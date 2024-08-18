using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class BaiTap01
    {
        static void Main(string[] args)
        {
            //baitap_01();
            //baitap_02();
            //baitap_03();
            //baitap_04();
            //baitap_05();
            //baitap_06();
            //baitap_07();
            //baitap_08();
            //baitap_09();
            baitap_10();

        }
        static void baitap_01()
        {
            Console.Write("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
        }

        static void baitap_02()
        {

            Console.Write("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"before swap a = {a}, b = {b}");
            int temp = a;
            a = b; b = temp;
            Console.WriteLine($"after swap a = {a}, b = {b}");
            //req: DONOT use temporary variable
        }

        static void baitap_03()
        {
            Console.Write("Enter the first number:");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float num2 = float.Parse(Console.ReadLine());
            float product = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {product} ");
        }

        static void baitap_04()
        {
            const double metersPerFoot = 0.3048;
            Console.Write("Enter feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meters = feet * metersPerFoot;
            Console.WriteLine($"{feet} feet is equal to {meters} meters");
        }

        static void baitap_05()
        {
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Choose conversion:");
            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Write("Enter temperature in Celsius: ");
                double c = double.Parse(Console.ReadLine());
                double f = (c * 9 / 5) + 32;
                Console.WriteLine($"{c} Celsius is equal to {f} Fahrenheit");
            }
            else if (choice == 2)
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());
                double c = (f - 32) * 5 / 9;
                Console.WriteLine($"{f} Fahrenheit is equal to {c} Celsius");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void baitap_06()
        {
            Console.Write("Enter data type (int, float, double, char, bool, decimal): ");
            string dataType = Console.ReadLine();
            switch (dataType.ToLower())
            {
                case "int":
                    Console.WriteLine($"Size of int: {sizeof(int)} bytes");break;
                case "double":
                    Console.WriteLine($"Size of double: {sizeof(double)} bytes");break;
                case "char":
                    Console.WriteLine($"Size of char: {sizeof(char)} bytes");break;
                case "float":
                    Console.WriteLine($"Size of float: {sizeof(float)} bytes");break;
                case "bool":
                    Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");break;
                case "decimal":
                    Console.WriteLine($"Size of bool: {sizeof(decimal)} bytes"); break;
            }
            // Add other data types as needed
        }

        static void baitap_07()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            int asciiValue = Convert.ToInt32(ch);
            Console.WriteLine($"ASCII value of {ch} is {asciiValue}");
        }

        static void baitap_08()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle is:{area}");
        }

        static void baitap_09()
        {
            Console.Write("Enter the side of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("The area of the square is: " + area);
        }

        static void baitap_10()
        {
            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            int years = totalDays / 365;
            int weeks = (totalDays % 365) / 7;
            int days = (totalDays % 365) % 7;
            Console.WriteLine($"{totalDays} days is equal to {years} years, {weeks} weeks, and {days} days.");
        }

    }
}
