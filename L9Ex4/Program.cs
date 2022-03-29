class L9Ex4__L10Ex2
{
    static void Main()
    {
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        numOfLetters(word);

        Console.Write("\nPlease enter a word and end it with a full stop or period: ");
        recursiveLength();
    }

    static void numOfLetters(string word)
    {
        Console.WriteLine("\n{0} has a total of {1} letters", word, word.Length);
    }

    static int length = 0, count = 0;
    static char[] letters = new char[100];
    static void recursiveLength()
    {
        var x = Console.Read();
        letters[count] = Convert.ToChar(x);
        if (letters[count] == '.')
        {
            printResult(); 
            return;
        }
        count++; length++;
        recursiveLength();
    }

    static void printResult()
    {
        Console.WriteLine("\n");
        for(int i = 0; i < length; i++)
        {
            Console.Write(letters[i]);
        }
        Console.Write(" has a total of {0} letters",length);
    }
}