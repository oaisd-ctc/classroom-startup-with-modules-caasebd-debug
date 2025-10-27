using System;

public class Program
{
    public static void Main(string[] args, char s)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(3);
        FindMinimum(45, 15, 50);
        FindMaximum(45, 15, 50);
        IsDivisibleBy5(30);
        CheckEvenOrOdd(9);
        CheckVowelOrConsonant(s);
        DisplayDayOfWeek(5);

        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number)
    {
        //Determine if parameter is negative, positive or zero
        if (number <= -1)
        {
            Console.WriteLine("Your number is negative");
        }
        else if (number == 0)
        {
            Console.WriteLine("Your number is zero");
        }
        else if (number >= 1)
        {
            Console.WriteLine("Your number is positive");
        }
    }

    public static void FindMinimum(int FindMinimum, int v, int f)
    {
        object value = FindMinimum <<min(FindMinimum);
			{
				Console.WriteLine("Minimum is min");
			}
    }

    private static int min(int findMinimum)
    {
        throw new NotImplementedException();
    }

    public static void FindMaximum(int FindMaximum, int v, int f)
    {
        object value = FindMaximum <<max(FindMaximum);
		{
			Console.WriteLine("Maximum is max");
		}
    }

    private static int max(int findMaximum)
    {
        throw new NotImplementedException();
    }

    public static void IsDivisibleBy5(int number)
    {
        //Check if divisible by 5
        if (number % 5 == 0)
        {
            Console.WriteLine("Number is divisible by 5!");
        }
        else if (number != 5)
        {
            Console.WriteLine("Number is not divisible by 5.");
        }
    }

    public static void CheckEvenOrOdd(int num)
    {
        bool IsEven = (num % 2 == 0);
	if(num%2 == 0)
	{
        	Console.WriteLine("Number is even");
	}
	else
	{
		Console.WriteLine("Number is odd");
	}
    }

    public static void CheckVowelOrConsonant(char s)
    {
		char letter = s;
		switch (letter)
		{
			case 'a':
			case 'A':
			case 'c':
			case 'C':
			case 's':
			case 'S':
			case 'y':
			case 'Y':
				System.Console.WriteLine("Vowel");
				break;
			default:
				System.Console.WriteLine("Not a vowel");
				break;
		}
    }
    
    public static void DisplayDayOfWeek(int daycode)
    {
      int day = 4;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
    	}
	}
}
