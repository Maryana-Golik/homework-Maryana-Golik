namespace MyMatrixApp
{
    public class IntMatrix
    {
        private int[,] data;
        private int rows;
        private int cols;

        public IntMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < rows && j >= 0 && j < cols)
                    return data[i, j];
                else
                    throw new IndexOutOfRangeException("Індекс вийшов за межі масиву.");
            }
            set
            {
                if (i >= 0 && i < rows && j >= 0 && j < cols)
                    data[i, j] = value;
                else
                    throw new IndexOutOfRangeException("Індекс вийшов за межі масиву.");
            }
        }

        public (int Rows, int Cols) Size => (rows, cols);
    }
}
