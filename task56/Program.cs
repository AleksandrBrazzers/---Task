class Program
{
    static void Main()
    {
        int[,] m1 = new int[,] 
        { 
            { 2, 4 }, 
            { 3, 2 } 
        };
        int[,] m2 = new int[,] 
        { 
            { 3, 4 }, 
            { 3, 3 } 
        };

        int[,] result = MultiplyMatrices(m1, m2);

        Console.WriteLine("Результат:");
        PrintMatrix(result);
    }

    static int[,] MultiplyMatrices(int[,] m1, int[,] m2)
    {
        int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];

        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m2.GetLength(1); j++)
            {
                for (int k = 0; k < m1.GetLength(1); k++)
                {
                    result[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}