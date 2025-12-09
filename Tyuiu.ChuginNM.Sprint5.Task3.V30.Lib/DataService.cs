using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChuginNM.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string res = "";

            double y = (x != 0) ? Math.Round((Math.Pow(x, 3)-1)/(4*Math.Pow(x, 2)), 3) : 0;
            res += Convert.ToString(y);

            return res;
        }
    }
}
