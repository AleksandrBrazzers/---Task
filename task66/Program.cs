class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = m; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", m, n, sum);
    }
}