class L9Ex1
{
    static void Main()
    {
        double coeffx2 = 1, coeffx = 1, constant = 1;
        bool errorCatch = false;
        Console.WriteLine("THis is a program to solve the quadratic equation ax\u00B2 + bx + c = 0");

        while (errorCatch == false)
        {
            Console.Write("\nPlease enter the co-efficient of x\u00b2: ");
            errorCatch = double.TryParse(Console.ReadLine(), out coeffx2);
        }

        errorCatch = false;
        while (errorCatch == false)
        {
            Console.Write("\nPlease enter the co-efficient of x: ");
            errorCatch = double.TryParse(Console.ReadLine(), out coeffx);
        }

        errorCatch = false;
        while (errorCatch == false)
        {
            Console.Write("\nPlease enter the value of the constant c: ");
            errorCatch = double.TryParse(Console.ReadLine(), out constant);
        }

        solveQuadratic(coeffx2, coeffx, constant);
    }

    static void solveQuadratic(double a, double b, double c)
    {
        double root1 = 0, root2 = 0;

        root1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);

        root2 = (-b - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);

        Console.WriteLine("\nThe roots of {0}x\u00B2 {1}x {2} =0 are {3.xx},{4.xx}", a, b, c, root1, root2);

    }
}