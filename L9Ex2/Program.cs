using System.Numerics;
class L9Ex2
{
    static void Main()
    {
        bool errorCatch=false;
        int fact = 0;
        while (errorCatch == false)
        {
            Console.Write("\nPlease enter the number whose factorial you'd like to calculate: ");
            errorCatch = int.TryParse(Console.ReadLine(), out fact);
            Console.WriteLine("\n");
        }
        Console.WriteLine("\nThe factorial of {0} is {1}",fact,CalcFactorial(fact));
    }
    static BigInteger factorial=1;
    static BigInteger CalcFactorial(int fact)
    {
        if(fact <= 0)
        {
            return 1;
        }

        if(fact == 1)
        {
            return factorial;
        }
        factorial *= fact;
        return CalcFactorial(fact-1);
    }
}