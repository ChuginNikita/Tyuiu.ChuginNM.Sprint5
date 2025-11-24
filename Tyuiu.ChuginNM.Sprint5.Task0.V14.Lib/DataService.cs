using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChuginNM.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            double res = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            string output = Convert.ToString(Math.Round(res, 3));
            return output;
        }
    }
}
