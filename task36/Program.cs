﻿class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент массива: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (i % 2 != 0)
            {
                sum += arr[i];
            }
        }

        Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
    }
}