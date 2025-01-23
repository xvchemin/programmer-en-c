//TODO : Créer une boucle for et while qui affiche à 5 reprises la phrase, « Je m'amuse comme un fou ! ».

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Je m'amuse comme un fou !");
//}


int x = 0;

while (x < 5)
{
    x += 1;

    if (x == 4)
    {
        continue;
    }
    Console.WriteLine("Je m'amuse comme un fou !");
}

Console.WriteLine("J'en ai marre !");

