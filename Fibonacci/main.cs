using System;



public class Fibonacci 
{
    public static void Main(string[] args) 
    {
        int numOne = 0;
        int numTwo = 1;
        Console.WriteLine("Enter Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(numOne + ", " + numTwo + ", ");
        for (int i = 2; i < n; i++)
        {
            int numThree = numOne + numTwo;
            Console.Write(numThree + ", ");
            numOne = numTwo;
            numTwo = numThree;
        }
    }
}