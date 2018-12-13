using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "This is some text";
            string nullStr = null;
            string emptyStr = String.Empty;

            char[] letters = {'A', 'B', 'C', 'X', 'Y', 'Z'};
            string xyz = new string(letters, 3, 3);

            Console.WriteLine($"Last {xyz.Length} alphabet letters: {xyz}");



            // Substrings

            string motto = "Programming is great!";
            string motto2 = motto.Replace("Programming", "C#");
            string substr = motto2.Substring(0, 2);

            Console.WriteLine(motto);
            Console.WriteLine($"\tindex of 'g': {motto.IndexOf('g')}");
            Console.WriteLine(motto2);
            Console.WriteLine(substr);



            // String concatenation
            string message = "\nHave a ";
            string message2 = "great day!";
            message += emptyStr + message2;

            Console.WriteLine(message);



            // Immutability

            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";

            Console.WriteLine("\n" + s2);


            // Identify a numeric value in a string

            int num;
            string numStr = "1024";
            bool isANum = int.TryParse(numStr, out num);

            Console.WriteLine($"\nIs {numStr} a number ({num.GetType()})? {isANum}");
        }
    }
}
