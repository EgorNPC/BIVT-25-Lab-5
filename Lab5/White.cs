using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class White
    {
        public double Task1(int[,] matrix)
        {
            double average = 0;

            // code here
            double sum = 0;
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
            }

            if (count > 0) average = sum / count;
            // end

            return average;
        }
        public (int row, int col) Task2(int[,] matrix)
        {
            int row = 0, col = 0;

            // code here
            int min = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            // end

            return (row, col);
        }
        public void Task3(int[,] matrix, int k)
        {

            // code here
            if (k < 0 || k >= matrix.GetLength(1)) return;

            int maxRow = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, k] > matrix[maxRow, k]) maxRow = i;
            }

            if (maxRow != 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int temp = matrix[0, j];
                    matrix[0, j] = matrix[maxRow, j];
                    matrix[maxRow, j] = temp;
                }
            }
            // end

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            if (matrix.GetLength(0) == 1)
            {
                answer = new int[0, matrix.GetLength(1)];
                return answer;
            }

            int minRow = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] < matrix[minRow, 0]) minRow = i;
            }

            answer = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            int newRow = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i != minRow)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        answer[newRow, j] = matrix[i, j];
                    }
                    newRow++;
                }
            }
            // end

            return answer;
        }
        public int Task5(int[,] matrix)
        {
            int sum = 0;

            // code here
            if (matrix.GetLength(0) != matrix.GetLength(1)) return 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            // end

            return sum;
        }
        public void Task6(int[,] matrix)
        {

            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int maxBefore = -1;
                int lastNegative = -1;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        lastNegative = j;
                    }
                    else if (lastNegative == -1)
                    {
                        if (maxBefore == -1 || matrix[i, j] > matrix[i, maxBefore])
                        {
                            maxBefore = j;
                        }
                    }
                }

                if (maxBefore != -1 && lastNegative != -1)
                {
                    int temp = matrix[i, maxBefore];
                    matrix[i, maxBefore] = matrix[i, lastNegative];
                    matrix[i, lastNegative] = temp;
                }
            }
            // end

        }
        public int[] Task7(int[,] matrix)
        {
            int[] negatives = null;

            // code here
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0) count++;
                }
            }

            if (count == 0) return null;

            negatives = new int[count];
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negatives[index] = matrix[i, j];
                        index++;
                    }
                }
            }
            // end

            return negatives;
        }
        public void Task8(int[,] matrix)
        {

            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix.GetLength(1) == 1) continue;

                int maxIndex = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[i, maxIndex]) maxIndex = j;
                }

                if (maxIndex == 0)
                {
                    matrix[i, 1] *= 2;
                }
                else if (maxIndex == matrix.GetLength(1) - 1)
                {
                    matrix[i, maxIndex - 1] *= 2;
                }
                else
                {
                    if (matrix[i, maxIndex - 1] <= matrix[i, maxIndex + 1])
                        matrix[i, maxIndex - 1] *= 2;
                    else
                        matrix[i, maxIndex + 1] *= 2;
                }
            }
            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int cols = matrix.GetLength(1);
                for (int j = 0; j < cols / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, cols - 1 - j];
                    matrix[i, cols - 1 - j] = temp;
                }
            }
            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here
            if (matrix.GetLength(0) != matrix.GetLength(1)) return;

            int n = matrix.GetLength(0);
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[i, j] = 1;
                }
            }
            // end

        }
        public int[,] Task11(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int good = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int zero = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zero = 1;
                        break;
                    }
                }
                if (zero == 0) good++;
            }

            answer = new int[good, matrix.GetLength(1)];
            int row = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int zero = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zero = 1;
                        break;
                    }
                }

                if (zero == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        answer[row, j] = matrix[i, j];
                    }
                    row++;
                }
            }

            // end

            return answer;
        }
        public void Task12(int[][] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    int sum1 = 0;
                    if (array[j] != null)
                    {
                        for (int k = 0; k < array[j].Length; k++)
                        {
                            sum1 += array[j][k];
                        }
                    }

                    int sum2 = 0;
                    if (array[j + 1] != null)
                    {
                        for (int k = 0; k < array[j + 1].Length; k++)
                        {
                            sum2 += array[j + 1][k];
                        }
                    }

                    if (sum1 > sum2)
                    {
                        int[] temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            // end

        }
    }
}
