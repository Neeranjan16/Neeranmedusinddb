using System;


class reverse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();

        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);

        Console.WriteLine("Reverse of the word: ");
        Console.WriteLine(new string(charArray));
    }
}

