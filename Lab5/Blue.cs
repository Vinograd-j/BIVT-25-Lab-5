using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Blue
    {
        public double[] Task1(int[,] matrix)
        {
            double[] answer = new double[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                        sum += matrix[i, j];
                }
                
                answer[i] = sum / (double)matrix.GetLength(1);
            }

            return answer;
        }
        public int[,] Task2(int[,] matrix)
        {
            int[,] answer = null;

            int maxElement = matrix[0, 0];
            int imax = 0, jmax = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        imax = i;
                        jmax = j;
                    }
                }
            }
            
            answer = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                if (i == imax)
                    continue;
                
                for (int j = 0; j < answer.GetLength(0); j++)
                {
                    if (j == jmax)
                        continue;
                    
                    answer[i, j] = matrix[i, j];
                }
            }
            
            return answer;
        }
        public void Task3(int[,] matrix)
        {

            

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[] Task5(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task6(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public int[][] Task12(int[][] array)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
    }
}