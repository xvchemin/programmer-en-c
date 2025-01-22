//Console.WriteLine("Bonjour le monde !");


using System;

namespace Hello
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            AfficheBonjour("Bonjour le monde !");
        }
        private static void AfficheBonjour(string phrase)
        {
            Console.WriteLine(phrase);
        }
    }
}
