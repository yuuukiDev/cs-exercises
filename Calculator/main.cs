using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        int numOne, numTwo;
        string? Operator;
        int result = 0;
        Console.WriteLine("Enter First Number: ");
        numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        numTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Operator (+, -, *, /, %): ");
        Operator = Console.ReadLine();

        if (Operator == "+") {
            result = numOne + numTwo;
        } else if (Operator == "-") {
            result = numOne - numTwo;
        } else if(Operator == "*") {
            result = numOne * numTwo;
        } else if (Operator == "/") {
            result = numOne / numTwo;
        } else if (Operator == "%") {
            result = numOne % numTwo;
        } else {
            Console.WriteLine("Invalid Operator, Try Again!");
        }
        Console.WriteLine("Result: " + result);
    }
}