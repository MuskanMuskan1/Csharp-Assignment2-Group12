using System;

namespace CsharpAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcatenateNames("Muskan""Suchneet");
            double tempC = 25;
            Console.WriteLine($"{tempC}°C = {CelsiusToFahrenheit(tempC)}°F");
            double tempF = 77;
            Console.WriteLine($"{tempF}°F = {FahrenheitToCelsius(tempF)}°C");
            PrintHello();
        }

        static void ConcatenateNames(string firstName, string lastName)
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static void PrintHello()
        {
            Console.WriteLine("Hello from Group 12!");
        }
    }
}
