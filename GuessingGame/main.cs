using System;


public class GuessingGame 
{
    public static void Main(string[] args)
    {
    Random rnd = new Random();
    int computerNumber = rnd.Next(0, 100);
    while (true) 
        {
            int playerNumber = Convert.ToInt32(Console.ReadLine());
            if (computerNumber > playerNumber)
            {
                Console.WriteLine("Low Number");
            }
            else if(computerNumber < playerNumber)
            {
                Console.WriteLine("High Number");
            }
            else
            {
                Console.WriteLine("Good Job");
                break;
            }
        }
    }
}