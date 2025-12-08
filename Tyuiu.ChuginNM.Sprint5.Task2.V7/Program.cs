using Tyuiu.ChuginNM.Sprint5.Task2.V7.Lib;

namespace Tyuiu.ChuginNM.Sprint5.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение, записывает результат   *");
            Console.WriteLine("* в таблицу в файл и печатает его на экране.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.WriteLine($"Введите элемент [{i}, {j}]: ");
                    matrix [i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            string textFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            var x = ds.SaveToFileTextData(matrix);
            File.WriteAllText(textFile, x);
        }
    }
}