using System;

namespace MyMatrixApp
{
    class Program
    {
        static void Main()
        {
            IntMatrix matrix = new IntMatrix(3, 4);

            for (int i = 0; i < matrix.Size.Rows; i++)
            {
                for (int j = 0; j < matrix.Size.Cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            for (int i = 0; i < matrix.Size.Rows; i++)
            {
                for (int j = 0; j < matrix.Size.Cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine(matrix[5, 0]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}

