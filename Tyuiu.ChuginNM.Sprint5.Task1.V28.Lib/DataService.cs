using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChuginNM.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            List<int> data = new List<int>();

            string table = "-----------------\n" +
                           "| x   | y       |\n";

            for (int x = startValue; x <= stopValue; x++)
            {
                double funcResult = (x - 0.7 != 0) ? Math.Round((Math.Cos(x)) / (x - 0.7) - Math.Sin(x) * 12 * x + 2, 2) : 0;
                table += "| " + Convert.ToString(x).PadRight(3) + " | " + Convert.ToString(funcResult).PadRight(7) + " |\n";

            }

            table += "-----------------\n";

            return table;
        }
    }
}
