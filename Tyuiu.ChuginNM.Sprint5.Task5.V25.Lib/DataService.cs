using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChuginNM.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            double res = -5973964.557;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) == null)
                {
                    res *= Double.Parse(line, CultureInfo.InvariantCulture);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
