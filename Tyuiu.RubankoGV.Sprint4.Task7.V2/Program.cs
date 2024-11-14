using Tyuiu.RubankoGV.Sprint4.Task7.V2.Lib;
namespace Tyuiu.RubankoGV.Sprint4.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 597643158942. Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "597643158942";
            Console.WriteLine("Исходная строка: " + value);

            Console.WriteLine("Введите количество строк матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[n, m];

            int index = 0;

            Console.WriteLine("\nMассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, value);
            Console.WriteLine($"Сумма нечетных элементов массива равна: {res}");
            Console.ReadKey();
        }
    }
}
