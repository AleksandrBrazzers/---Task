Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Число\tКуб");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}\t{Math.Pow(i,3)}");
        }