public class Library
{
    public static int[] CalculateSumOfNegativeElements(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[] sumArray = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < 0)
                {
                    sum += matrix[i, j];
                }
            }
            sumArray[i] = sum;
        }

        return sumArray;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введите элементы матрицы:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[] sumArray = Library.CalculateSumOfNegativeElements(matrix);

        Console.WriteLine("Результат:");

        foreach (int sum in sumArray)
        {
            Console.Write(sum + " ");
        }
    }
}