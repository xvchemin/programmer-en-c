using System;

namespace Hello
{
    /// <summary>
    /// Ceci est une implémentation du message traditionnel « Hello world! »
    /// </summary>
    /// <remarks>Créée par l'équipe éducative d'OpenClassrooms</remarks>
    public class HelloWorld
    {
        /// <summary>
        /// Le programme commence ici
        /// </summary>
        public static void Main(string[] args)
        {
            AfficheBonjour("Xavier");
        }


        private static void AfficheBonjour(string args )
        {
            Console.WriteLine("Hello " + args + "!");
        }
    }
}