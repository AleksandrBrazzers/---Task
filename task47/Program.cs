class Program {
    static void Main(string[] args) {
        Console.Write("Введите количество строк: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                array[i, j] = random.NextDouble();
            }
        }

        Console.WriteLine("Двумерный массив случайных вещественных чисел:");
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}