using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChuginNM.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = double.Parse(strx);
            double y = Math.Round(((1 / (Math.Cos(x) + x)) - 4.12 * x), 3);
            return y;
        }
    }
}
