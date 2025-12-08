using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChuginNM.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] % 2 != 0) { matrix[i, j] = 0; } 
                    else { matrix[i, j] = matrix[i, j]; }
                }
            }

            string res = "";

            res += matrix[0, 0] + ";" + matrix[0, 1] + ";" + matrix[0, 2] + "\n"
                + matrix[1, 0] + ";" + matrix[1, 1] + ";" + matrix[1, 2] + "\n"
                + matrix[2, 0] + ";" + matrix[2, 1] + ";" + matrix[2, 2];

            return res;

        }
    }
}
