using TestLib;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLibService ts = new TestLibService();

            Console.WriteLine(ts.nanForUpper("SDNsSA2KgDNJ5ShAJN3DNA6SJ"));

            Console.WriteLine(ts.countSymbol("sv1a6dbNJ5S2KDS53nda4nkd5s7S,D", '5'));

            Console.WriteLine(ts.countSymbol("s1ah2nds4njah34nd", 'h'));

            Console.WriteLine(ts.forUpper("s3Ssads6asGa4dsa4hhgh2dfG"));

            Console.WriteLine(ts.nanForDigit("09s87654g32123d45678a")); // 5

            Console.WriteLine(ts.forDigit("3fja4lksdfj2lkjl3k6j9"));

            Console.WriteLine(ts.nanForUpper("DSADlJHSADGtASUIyDSrkAN"));

            Console.WriteLine(ts.nanForDigit("r3j4658w31d1"));

            Console.WriteLine(ts.forUpper("KsjDsSsadsaFs"));

            Console.WriteLine(ts.forDigit("sdj433sakdjsa234sa3dns5ja"));












        }
    }
}