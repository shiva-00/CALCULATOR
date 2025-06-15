using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Userchoice
{
    public List<int> Choice()
    {
        List<int> numbers = new List<int>();
        int num;
        string? input;
        while (true)
        {
            Console.WriteLine("Enter a number (Press Enter without input to finish):");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            if (int.TryParse(input, out num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid Input ---- Please Try Again: ");
            }
        }
        return numbers;
    }
}

class Sqrt
{
    public static async Task SQRT()
    {
        Console.WriteLine("Please Enter the Number: ");
        string? input = Console.ReadLine();
        double num;
        if (double.TryParse(input, out num))
        {
            await Task.Delay(1000);
            Console.WriteLine($"The Square Root of the given number is {Math.Sqrt(num)}\n");
        }
        else
        {
            Console.WriteLine("Please enter a Valid Number: ");
            await Task.Delay(1000);
            return;
        }
    }
}

public class Exp
{
    public static async Task Exponentiation()
    {
        Userchoice data = new();
        List<int> numbers = data.Choice();
        int length = numbers.Count;
        if (length > 2)
        {
            await Task.Delay(1000);
            Console.WriteLine("Cannot perform more than Two numbers. Please try again. ");
            return;
        }
        double result = 1;
        int Base = numbers[0];
        int exp = numbers[1];

        for (int i = 0; i < exp; i++)
        {
            result *= Base;
        }
        await Task.Delay(1000);
        Console.WriteLine("Please Wait ---------------\n");
        await Task.Delay(1000);
        Console.WriteLine($"The result of the given exponentiaion is {result}");
        await Task.Delay(1000);
    }
}

public class Mod
{
    public static async Task Modular()
    {
        Userchoice data = new();
        List<int> numbers = data.Choice();
        int length = numbers.Count;
        if (length < 2)
        {
            await Task.Delay(1000);
            Console.WriteLine("Need Atleast TWO numbers to perform Modular Divion");
            return;
        }
        if (numbers.Skip(1).Any(n => n == 0))
        {
            await Task.Delay(1000);
            Console.WriteLine("Cannot be Divisible by ZERO");
        }
        double remainder = numbers[0];
        for (int i = 1; i < length; i++)
        {
            remainder %= numbers[i];
        }
        Console.WriteLine("Please Wait --------------------\n");
        await Task.Delay(1000);
        Console.WriteLine($"The Remainder of the given numbers is {remainder}");
        await Task.Delay(1000);

    }
}

public class Div
{
    public static async Task Division()
    {
        Userchoice data = new();
        List<int> numbers = data.Choice();
        int length = numbers.Count;
        if (length < 2)
        {
            await Task.Delay(1000);
            Console.WriteLine("Need Atleast Two Numbers to perform Division");
            return;
        }
        if (numbers.Skip(1).Any(n => n == 0))
        {
            await Task.Delay(1000);
            Console.WriteLine("Cannot be divide by ZERO ");
            return;
        }
        double result = numbers[0];
        for (int i = 1; i < length; i++)
        {
            result /= numbers[i];
        }
        Console.WriteLine("Please Wait: ------------------------\n");
        await Task.Delay(1000);
        Console.WriteLine($"The Result of the given numebers is : {result}");
        await Task.Delay(1000);
    }
}
public class Mul
{

    public static async Task MultiplicationAsync()
    {
        Userchoice data = new();
        List<int> numbers = data.Choice();
        int product = 1;
        if (numbers.Count > 0)
        {
            foreach (int M in numbers)
            {
                product *= M;
            }
        }
        else
        {
            product = 0;
        }
        Console.WriteLine("Please Wait: ------------------------\n");
        await Task.Delay(1000);
        Console.WriteLine($"THE PRODUCT OF THE GIVEN NUMBERS IS  {product}\n");
        await Task.Delay(1000);
    }
}

public class Add
    {
    public static async Task AdditionAsync()
    {
        
        Userchoice data = new();
        List<int> numbers = data.Choice(); 
        int sum = 0;
        foreach (int N in numbers)
        {
            sum += N;
        }
        Console.WriteLine("Please Wait: ------------------------\n");
        await Task.Delay(1000);
        Console.WriteLine($"THE SUM OF GIVEN NUMBERS IS  {sum}\n");
        await Task.Delay(1000);
        }
    }


public class Sub
{
    public static async Task SubtractionAsync()
    {
        
        Userchoice data = new();
        List<int> number = data.Choice();
        int result = 0;
        if (number.Count > 0)
        {
            result = number[0];
            for (int i = 1; i < number.Count; i++)
            {
                result -= number[i];
            }
        }
        Console.WriteLine($"Please Wait: ------------------------\n");
        await Task.Delay(1000);
        Console.WriteLine($"THE DIFFERENCE BETWEEN GIVEN NUMBERS IS  : {result}\n");
        await Task.Delay(1000);
    }
}
class Program
{
        static async Task Main()
        {
        while (true)
        {
            Console.WriteLine("Please Choose the arithmatic you want to perform:  ");
            Console.WriteLine("Choose\n 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n 5 - Modular_Division\n 6 - Exponentiation \n 7 - SquareRoot\n Press ENTER without input to Exit");
            string? input = Console.ReadLine();
            int choice;
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("PRESS ENTER TWICE FOR RESULT:  ");
                        await Task.Delay(1000);
                        await Add.AdditionAsync();
                        break;
                    case 2:
                        Console.WriteLine("PRESS ENTER TWICE FOR RESULT:  ");
                        await Task.Delay(1000);
                        await Sub.SubtractionAsync();
                        break;
                    case 3:
                        Console.WriteLine("PRESS ENTER TWICE FOR RESULT:  ");
                        await Task.Delay(1000);
                        await Mul.MultiplicationAsync();
                        break;
                    case 4:
                        Console.WriteLine("PRESS ENTER TWICE FOR RESULT: ");
                        await Task.Delay(1000);
                        await Div.Division();
                        break;
                    case 5:
                        Console.WriteLine("PRESS ENTER TWICE FOR RESULT");
                        await Task.Delay(1000);
                        await Mod.Modular();
                        break;
                    case 6:
                        Console.WriteLine("PRESS ENTER TWICE FOR RESULT: ");
                        await Task.Delay(1000);
                        await Exp.Exponentiation();
                        break;
                    case 7:
                        Console.WriteLine("PRESS ENTER TWICE FOR THE RESULT");
                        await Task.Delay(1000);
                        await Sqrt.SQRT();
                        break;
                        
                    default:
                        Console.WriteLine("INVALID CHOICE : Please Enter Again: ");
                        break;
                }
            }
            Console.WriteLine("Do you wish to go to MENU: Select (Y/N):");
            string? user = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(user) && user.ToUpper() == "Y")
            {
                Console.WriteLine("Returning to MENU...");
                await Task.Delay(1500);
            }
            else
            {
                return;
            }
                
            }
        }

}