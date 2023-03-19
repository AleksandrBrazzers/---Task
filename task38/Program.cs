class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент массива: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] < min)
            {
                min = arr[i];
            }

            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        int diff = max - min;
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
    }
}