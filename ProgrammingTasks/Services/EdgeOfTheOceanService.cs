using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace ProgrammingTasks.Services
{
    public interface IEdgeOfTheOceanService
    {
        int AdjacentElementsProduct(int[] inputArray);
        bool AlmostIncreasingSequence(int[] sequence);
        int MakeArrayConsecutive2(int[] statues);
        int MatrixElementsSum(int[][] matrix);
        int ShapeArea(int n);
    }

    public class EdgeOfTheOceanService : IEdgeOfTheOceanService
    {
        public int AdjacentElementsProduct(int[] inputArray)
        {
            int max = 0;
            max = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] * inputArray[i + 1] > max)
                {
                    max = inputArray[i] * inputArray[i + 1];
                }
            }
            return max;
        }

        public int ShapeArea(int n)
        {
            int i = 2;
            int sum = 1;
            while (i <= n)
            {
                sum = sum + (4 * (i - 1));
                i++;
            }
            return sum;
        }

        public int MakeArrayConsecutive2(int[] statues)
        {
            int count = statues.Max() - statues.Min() - 1;
            return count - (statues.Length - 2);
        }

        public bool AlmostIncreasingSequence(int[] sequence)
        {
            bool isRemoved = false;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                Console.WriteLine(sequence[i]);
                if (sequence[i] > sequence[i + 1] && isRemoved == false)
                {
                    isRemoved = true;
                }
                else if (sequence[i] > sequence[i + 1] && isRemoved == true)
                {
                    return false;
                }
            }
            return true;
        }

        public int MatrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            for (int j = 0; j < matrix[0].Length; j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i][j] == 0)
                    {
                        break;
                    }
                    sum += matrix[i][j];
                }
            }
            return sum;
        }
    }
}
