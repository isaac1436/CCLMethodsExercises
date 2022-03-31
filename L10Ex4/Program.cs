class L10Ex4
{
    static int start, end, endVal;

    static void Main()
    {
        bool errorCatch = false;

        Console.Write("Please enter the starting point of this experiment: ");
        while (errorCatch == false) { errorCatch = int.TryParse(Console.ReadLine(), out start); }

        errorCatch = false;
        Console.Write("\nPlease enter the endpoint of this experiment: ");
        while (errorCatch == false) { errorCatch = int.TryParse(Console.ReadLine(), out end); }

        errorCatch = false;
        Console.Write("\nPlease enter the value you want to use to end the sequence: ");
        while (errorCatch == false) { errorCatch = int.TryParse(Console.ReadLine(), out endVal); }

        decimal starttime = Environment.TickCount;

        numGen(0);

        decimal endtime = Environment.TickCount;
        Console.WriteLine("\n It took exactly {0} seconds to find {1} in the range {2}-{3}", (endtime-starttime)/1000, endVal, start, end);

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