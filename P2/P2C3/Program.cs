//TODO : Créer une boucle for et while qui affiche à 5 reprises la phrase, « Je m'amuse comme un fou ! ».
Console.WriteLine("Bonjour !");

/* for (int i = 0; i < 5; i++)
     {
         Console.WriteLine("Je m'amuse comme un fou !");
     };
*/

int J = 0;

while (J < 5)
{
    J++;

    if (J == 4) {  continue; };

    Console.WriteLine("Je m'amuse comme un fou !" + J);
};
