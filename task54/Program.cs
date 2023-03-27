class Program
{
    static void Main(string[] args)
    {
        int[,] m = new int[,] 
        { 
        { 1, 4, 7, 2 },
        { 5, 9, 2, 3 },
        { 8, 4, 2, 4 } 
        };
        for (int i = 0; i < m.GetLength(0); i++)
        {
            int[] row = new int[m.GetLength(1)];
            for (int j = 0; j < m.GetLength(1); j++)
            {
                row[j] = m[i, j];
            }
            Array.Sort(row, (a, b) => -1 * a.CompareTo(b));
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = row[j];
            }
        }

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}