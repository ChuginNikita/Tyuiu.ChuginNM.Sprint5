using TestLib;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLibService ts = new TestLibService();

            Console.WriteLine(ts.replaceWith("H65jSV5Dk8s", '5', '8'));
            Console.WriteLine(ts.replaceWith("2gUU63sf82s1Ul7", 'U', '*'));
            Console.WriteLine(ts.replaceWith("J8sdsaj8an8SA", '8', 'a'));
            Console.WriteLine(ts.replaceWith("HSdsmandsHsk", 'H', 'h'));
            Console.WriteLine(ts.replaceWith("sayhdkysanjhy", 'y', '0'));

            Console.WriteLine(ts.replaceWith("dkGsHHSadGnsHa", 'H', 'h'));
            Console.WriteLine(ts.replaceWith("KbhYvhFp", 'h', '#'));
            Console.WriteLine(ts.replaceWith("326198432994", '9', 'K'));
            Console.WriteLine(ts.replaceWith("K*nHd**lS7l", '*', '#'));
            Console.WriteLine(ts.replaceWith("S&N*DK*s2d7", '*', '#'));














        }
    }
}