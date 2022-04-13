class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter an integer: ");
        string blah = Console.ReadLine();
        int input = int.Parse(blah);

        //1291 will cause overflow
        if (input <= 0 || input > 1290)
        {
            while (true)
            {
                Console.WriteLine("Not a valid input.");
                blah = Console.ReadLine();
                input = int.Parse(blah);
                if(input > 0)
                {
                    break;
                }
            }
        }

        for (int i = 1; i <= input; i++)
        {
            int square = Squared(i);
            int cube = Cubed(i);
            Console.WriteLine($"Number: {i} Squared: {square} Cubed: {cube}");
        }
        Console.WriteLine("Continue? y/n: ");
        string yn = Console.ReadLine();
        if (yn == "y") {
            Main();
        }
    }

    public static int Squared(int x)
    {
        return x * x;
    }

    public static int Cubed(int x)
    {
        return x * x * x;
    }
}
