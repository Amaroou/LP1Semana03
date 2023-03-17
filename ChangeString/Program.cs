using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string - ");
            string teststring = Console.ReadLine();
            Console.WriteLine("Enter a character - ");
            string character = Console.ReadLine();
            var str = teststring;
            var charstoremove = new string[] {character};
            foreach (var c in charstoremove)
            {
                str = str.Replace(character, string.Empty);
            }
            Console.WriteLine(str);
        }


    }
}
