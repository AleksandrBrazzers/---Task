class Program {
    static void Main(string[] args) {
        Console.Write("Введите количество чисел: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < size; i++) {
            Console.Write($"Введите число {i + 1}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {count}");
    }
}