class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(n);
    }
    static void PrintNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }

        Console.WriteLine(n);

        PrintNumbers(n - 1);
    }
}