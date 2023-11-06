using System;
using System.IO;



class WordCount 
{
    static void Main(string[] args)
    {
        string filePath = "text.txt";
        if(!File.Exists(filePath))
        {
            Console.WriteLine("File Not Found: " + filePath);
            return;
        }
        string text = File.ReadAllText(filePath);
        int count = 0;
        
        for(int i = 0; i <= text.Length; i++)
        {
            count = i;
        }
        Console.WriteLine("Word: " + text + ", " + "Word Count: " + count);
    }
}