using System.Data;

namespace TestLib
{
    public class TestLibService
    {
        public int countSymbol(string input, char data)
        {
            return input.Count(c => c == data);
        }

        public string forUpper(string input) 
        {
            string newContent = "";
        
            foreach (char c in input) 
            {
                if (char.IsUpper(c)) { newContent += c; }
            }
            return newContent;
        }

        public string forDigit(string input)
        {
            string newContent = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c)) { newContent += c; }
            }
            return newContent;
        }

        public string nanForUpper(string input)
        {
            string newContent = "";

            foreach (char c in input)
            {
                if (!char.IsUpper(c)) { newContent += c; }
            }
            return newContent;
        }

        public string nanForDigit(string input)
        {
            string newContent = "";

            foreach (char c in input)
            {
                if (!char.IsDigit(c)) { newContent += c; }
            }
            return newContent;
        }

        public string replaceWith(string input, char c1, char c2)
        {
            return input.Replace(c1, c2);
        }


    }
}
