class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,] 
        { 
            { 1, 4, 7, 2 }, 
            { 5, 9, 5, 3 }, 
            { 8, 4, 2, 4 } 
        }; 
        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Введите номер столбца: ");
        int column = Convert.ToInt32(Console.ReadLine()); 

        if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
            int element = array[row, column]; 
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве");
        }
    }
}