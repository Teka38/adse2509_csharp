using System;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C#'s date and time formatting and specifiers.
    /// </summary>
    public class DateTimeSpecifiers
    {
        static void Main(string[] args)
        {
            // Get current date and time
            DateTime currDateTime = DateTime.Now;

            // Display current date and time in various formats
            Console.WriteLine("Current Date and Time: {0}", currDateTime);
            Console.WriteLine(new string('-', 70));

            // Standard date and time format specifiers
            Console.WriteLine("C# Standard Date & Time Format Specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Short date (d): {currDateTime:d}");
            Console.WriteLine($"Long date (D): {currDateTime:D}");
            Console.WriteLine($"General date (G): {currDateTime:G}");
            Console.WriteLine($"Short time (t): {currDateTime:t}");
            Console.WriteLine($"Long time (T): {currDateTime:T}");
            Console.WriteLine($"RFC1123 (r): {currDateTime:r}");
            Console.WriteLine($"Sortable (s): {currDateTime:s}");
            Console.WriteLine($"Universal Sortable (u): {currDateTime:u}");
            Console.WriteLine($"Day of the month (M): {currDateTime:M}");
            Console.WriteLine($"Month of the year (y): {currDateTime:y}");
            Console.WriteLine(new string('-', 70));

            // Custom date and time format specifiers
            Console.WriteLine("C# Custom Date & Time Format Specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Full date & time: {currDateTime:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Date only: {currDateTime:dd/MM/yyyy}");
            Console.WriteLine($"12-hour format: {currDateTime:hh:mm:ss tt}");
            Console.WriteLine($"Day and Month name: {currDateTime:dddd, MMMM dd, yyyy}");
            Console.WriteLine(new string('-', 70));
        }
    }
}