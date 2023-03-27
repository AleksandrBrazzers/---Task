class Program
{
    static int a(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return a(m - 1, 1);
        }
        else
        {
            return a(m - 1, a(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = a(m, n);

        Console.WriteLine("Результат функции Аккермана для m = {0} и n = {1} равен {2}", m, n, result);
    }
}