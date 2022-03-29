using System.Numerics;
class L10Ex1
{
    static void Main()
    {
        bool errorCatch = false;
        int num = 0;
        while (errorCatch == false)
        {
            Console.Write("\nPlease enter the number whose sum you'd like to calculate: ");
            errorCatch = int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("\n");
        }
        Console.WriteLine("\nThe sum of numbers between 1 and {0} is {1}", num, sumNums(num));
    }
    static BigInteger sum = 0;
    static BigInteger sumNums(int num)
    {
        if (num <= 0)
        {
            return sum;
        }

        sum += num;
        return sumNums(num - 1);
    }
}