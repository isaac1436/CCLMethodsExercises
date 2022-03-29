class L10Ex4
{
    static int start, end, endVal;

    static void Main()
    {
        var time = new System.Diagnostics.Stopwatch();
        bool errorCatch = false;

        Console.Write("Please enter the starting point of this experiment: ");
        while (errorCatch == false) { errorCatch = int.TryParse(Console.ReadLine(), out start); }

        errorCatch = false;
        Console.Write("\nPlease enter the endpoint of this experiment: ");
        while (errorCatch == false) { errorCatch = int.TryParse(Console.ReadLine(), out end); }

        errorCatch = false;
        Console.Write("\nPlease enter the value you want to use to end the sequence: ");
        while (errorCatch == false) { errorCatch = int.TryParse(Console.ReadLine(), out endVal); }


        time.Start();
        numGen(0);
        time.Stop();
        Console.WriteLine("\n It took exactly {0} milliseconds to find {1} in the range {2}-{3}", time.ElapsedMilliseconds, endVal, start, end);

    }


    static void numGen(int num)
    {
        Random randomNum = new Random();
        num = randomNum.Next(start, end);

        if (num == endVal)
        {
            return;
        }

        numGen(num);
    }
}