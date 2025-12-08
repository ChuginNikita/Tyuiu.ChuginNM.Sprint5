namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = { { -9, 10, 2 }, { 4, -8, 1 }, { 5, 3, -6 } };
            //int[,] array = { { -5, 11, -4 }, { 1, 2, -4 }, { 4, 8, 3 } };
            int[,] array = { { -5, 7, -4 }, { 10, -12, -4 }, { 14, 8, 3 } };
            //int[,] array = { { 6, 9,  4 }, { 7, 2, 4 }, { 4, 8, 3 } };
            int rowSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum -= array[2, j];
            }

            Console.WriteLine(rowSum);


        }
    }
}