using System;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C#'s numeric specifiers and formatting options.
    /// </summary>
    public class NumericSpecifiers
    {
        static void Main(string[] args)
        {
            // Variables to hold sample numbers to be used in the program
            int intValue = 123457;
            double doubleValue = 321457.789;
            decimal decValue = 123457.987m;

            // Currency format specifiers
            Console.WriteLine("Currency Format (C):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{intValue:c}");
            Console.WriteLine(intValue.ToString("C"));
            Console.WriteLine($"{doubleValue:c}");
            Console.WriteLine(doubleValue.ToString("C"));
            Console.WriteLine($"{decValue:c}");
            Console.WriteLine(new string('-', 70));

            // Decimal format specifier
            Console.WriteLine("Decimal Format (D):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("D"));
            Console.WriteLine($"{intValue:d}");
            Console.WriteLine($"{123:d7}"); // Padded with leading zeros
            Console.WriteLine(123.ToString("D7"));
            Console.WriteLine(new string('-', 70));

            // Exponential/Scientific format specifier
            Console.WriteLine("Exponential/Scientific Format (E):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:E}");
            Console.WriteLine($"{intValue:e}");
            Console.WriteLine(new string('-', 70));

            // Fixed-point format specifier
            Console.WriteLine("Fixed-point Format (F):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:E}");
            Console.WriteLine($"{doubleValue:e}");

            // Number format specifier
            Console.WriteLine("Number Format (N):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:N}");
            Console.WriteLine(doubleValue.ToString("N"));
            Console.WriteLine($"{decValue:n}");
            Console.WriteLine(new string('-', 70));

            // Percentage format specifier
            Console.WriteLine("Percentage Format (P):");
            Console.WriteLine(new string('-', 70));
            double percentage = .85;
            Console.WriteLine(percentage.ToString("P"));
            Console.WriteLine($"{percentage:p}");
            Console.WriteLine(new string('-', 70));

            // Hexadecimal format specifier
            Console.WriteLine("Hexadecimal Format (X):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("X"));
            Console.WriteLine($"Hexadecimal with padding (X7)\n{intValue:x7}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
        }
    }
}