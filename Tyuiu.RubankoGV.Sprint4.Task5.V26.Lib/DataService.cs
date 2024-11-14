using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RubankoGV.Sprint4.Task5.V26.Lib
{
    public class DataService : ISprint4Task5V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
