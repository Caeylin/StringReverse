using System;
using System.Text;

namespace StringReverse
{
    public class Program

    {
        public static void Main(string[] args)

        {
            Console.Write("Enter a string: ");
            Console.Write("Reversed string: " + Reverse(Console.ReadLine()));
        }
        public static string Reverse(string aString)
        {
            if (aString == null)
            {
                throw new ArgumentNullException();
            }
            var sb = new StringBuilder(aString);
            var maxIndex = sb.Length - 1;
            var halfLength = sb.Length / 2;
            for (var i = 0; i < halfLength; i++)
            {
                var charTemp = sb[i];
                sb[i] = sb[maxIndex - i];
                sb[maxIndex - i] = charTemp;
            }

            var reversedString = sb.ToString();
            return reversedString;
        }

    }
}
