namespace EvenOrOdd;

public class Program
{
    private static void PrintEvenNumbersInRange(int start, int end)
    {
        for (int i = start; i <= end; i++)
            if (i % 2 == 0)
                Console.WriteLine($"{i} es par.");
    }

    public static void Main(string[] args)
    {
        PrintEvenNumbersInRange(1, 100);
    }
}