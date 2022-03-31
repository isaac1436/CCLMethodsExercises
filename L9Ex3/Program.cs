class L9Ex3
{
    static string one = " one", two = " two", three = " three", four = " four", five = " five",
    six = " six", seven = " seven", eight = " eight", nine = "nine", zero = " zero";

    static string ten = " ten", eleven = " eleven", twelve = " twelve", thirteen = " thirteen", fourteen = " fourteen",
    fifteen = " fifteen", sixteen = " sixteen", seventeen = " seventeen", eighteen = " eighteen", nineteen = " nineteen";

    static string twenty = " twenty", thirty = " thirty", fourty = " fourty", fifty = " fifty",
    sixty = " sixty", seventy = " seventy", eighty = " eighty", ninety = " ninety";

    static string hundred = "One Hundred";
    static void Main()
    {

        int lastDigit = 0; int secondDigit = 0; int firstDigit = 0; int num = 0;

        Console.Write("Please Enter A number from 0 to 100 : ");
        num = int.Parse(Console.ReadLine());
        lastDigit = num % 10; secondDigit = (num / 10) % 10; firstDigit = (num / 100) % 10;
        if (firstDigit > 1 || firstDigit < 0)
        {
            Console.WriteLine("Invalid number entered");
        }
        else
        {
            toWords(lastDigit, secondDigit, firstDigit);
        }
    }

    static void toWords(int lastDigit, int secondDigit, int firstDigit)
    {
        if (firstDigit != 0)
        {
            Console.WriteLine("The number in words is {0}", hundred);
        }


        else if (firstDigit == 0)
        {
            if (secondDigit != 1 && secondDigit != 0)
            {
                if (secondDigit == 2) { Console.Write("The number in words is" + twenty); }
                if (secondDigit == 3) { Console.Write("The number in words is" + thirty); }
                if (secondDigit == 4) { Console.Write("The number in words is" + fourty); }
                if (secondDigit == 5) { Console.Write("The number in words is" + fifty); }
                if (secondDigit == 6) { Console.Write("The number in words is" + sixty); }
                if (secondDigit == 7) { Console.Write("The number in words is" + seventy); }
                if (secondDigit == 8) { Console.Write("The number in words is" + eighty); }
                if (secondDigit == 9) { Console.Write("The number in words is" + ninety); }

                if (lastDigit == 1) { Console.Write(one); }
                if (lastDigit == 2) { Console.Write(two); }
                if (lastDigit == 3) { Console.Write(three); }
                if (lastDigit == 4) { Console.Write(four); }
                if (lastDigit == 5) { Console.Write(five); }
                if (lastDigit == 6) { Console.Write(six); }
                if (lastDigit == 7) { Console.Write(seven); }
                if (lastDigit == 8) { Console.Write(eight); }
                if (lastDigit == 9) { Console.Write(nine); }
            }

            else if (secondDigit == 1)
            {
                switch (lastDigit)
                {
                    case 0: Console.Write("The number in words is" + ten); break;
                    case 1: Console.Write("The number in words is" + eleven); break;
                    case 2: Console.Write("The number in words is" + twelve); break;
                    case 3: Console.Write("The number in words is" + thirteen); break;
                    case 4: Console.Write("The number in words is" + fourteen); break;
                    case 5: Console.Write("The number in words is" + fifteen); break;
                    case 6: Console.Write("The number in words is" + sixteen); break;
                    case 7: Console.Write("The number in words is" + seventeen); break;
                    case 8: Console.Write("The number in words is" + eighteen); break;
                    case 9: Console.Write("The number in words is" + nineteen); break;
                }
            }

            else if (secondDigit == 0)
            {
                if (lastDigit == 0) { Console.Write("The number in words is" + zero); }
                if (lastDigit == 1) { Console.Write("The number in words is" + one); }
                if (lastDigit == 2) { Console.Write("The number in words is" + two); }
                if (lastDigit == 3) { Console.Write("The number in words is" + three); }
                if (lastDigit == 4) { Console.Write("The number in words is" + four); }
                if (lastDigit == 5) { Console.Write("The number in words is" + five); }
                if (lastDigit == 6) { Console.Write("The number in words is" + six); }
                if (lastDigit == 7) { Console.Write("The number in words is" + seven); }
                if (lastDigit == 8) { Console.Write("The number in words is" + eight); }
                if (lastDigit == 9) { Console.Write("The number in words is" + nine); }
            }
        }
    }
}