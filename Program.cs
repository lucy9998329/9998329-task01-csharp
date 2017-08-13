using System;

namespace _9998329_task01_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();


            string Celsius = "Celsius";
            string Fahrenheit = "Fahrenheit";
            Console.WriteLine("Please enter the conversion");
            string userInput = Console.ReadLine();
            
            if(userInput == Celsius)
            {
            Console.WriteLine("Please enter Celsius degree");
            double celsius = double.Parse(Console.ReadLine());
            double convertedCelsius = Math.Round((celsius * 9)/ 5 +32 ,1);
            
            Console.WriteLine($"Celsius = {convertedCelsius} Fahrenheit");
            Console.ReadLine();

            }
            else
            {
            if(userInput == Fahrenheit)
            {
            double fahrenheit = double.Parse(Console.ReadLine());
            
            double convertedFahrenheit = Math.Round((fahrenheit - 32 * 5)/ 9 ,1);
            
            Console.WriteLine($"Fahrenheit = {convertedFahrenheit} Celsius");
            Console.ReadLine();
            }

            

            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

            
        }
    }
}
}