namespace SnakeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int top = 0;
            int bottom = rows - 1;
            int left = 0;
            int right = cols - 1;

            int value = 1;

            while (value <= rows * cols)
            {
                // 1. Надясно
                for (int j = left; j <= right; j++)
                {
                    matrix[top, j] = value++;
                }
                top++;

                // 2. Надолу
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = value++;
                }
                right--;

                // 3. Наляво
                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--)
                    {
                        matrix[bottom, j] = value++;
                    }
                    bottom--;
                }

                // 4. Нагоре
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i, left] = value++;
                    }
                    left++;
                }
            }

            // Печат
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}