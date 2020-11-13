using System;
using UnleashedTest;

class Program
{    
    static void Main(string[] args)
    {
        String result = "";

        if (args.Length == 0) {
            Console.WriteLine("MoneyWord Unleashed test app");
            Console.WriteLine("No input - use dotnet run [dollar amount]");
            return;
        }
        result = MoneyWord.convertToWords(args[0]);
        Console.WriteLine(result);
    }
}
