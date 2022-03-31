class L10Ex3
{
    static int lim;
    static int[] divs;
    static void Main()
    {
        bool errorCatch = false;
        Console.Write("Please enter a number: ");
        while (errorCatch == false)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out lim);
            if (errorCatch == false || lim < 2) { Console.Write("Ivalid value entered. Please enter another value: "); }
        }
        divs = new int[lim];
        for (int i = 0; i < lim; i++) { divs[i] = i; }

        Console.Write("The prime numbers between 1 and {0} are: 1, 2", lim);
        primeNums(3);
    }

    static void primeNums(int num)
    {
        bool isPrime;
        if (num >= lim)
        {
            return;
        }
        isPrime = IsPrime(num);

        if (isPrime==true) { Console.Write(", " + num); }

        primeNums(num+1);
    }

    static bool IsPrime(int num)
    {
        bool isPrime=true;
        for (int i = 2; i <num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}