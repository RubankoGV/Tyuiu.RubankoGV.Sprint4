using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RubankoGV.Sprint4.Task3.V3.Lib

    public class DataService : ISprint4Task3V5
{
    public int Calculate(int[,] array)
    {
        int res = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res += array[i, 0];
        }
        return res;
    }
}
}
