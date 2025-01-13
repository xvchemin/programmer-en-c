// déclarer une variable int nommée allocationCourante
int allocationCourante = 200;
// déclarer une variable int epargne
int epargne = 3000;
int epargneParMois = 50;
const int objectifEpargne = 12000;
// déclarer une variable int budgetCourses
int budgetCourses = 500;

// TODO : créer une variable int nommée prime avec pour valeur initiale 500.
int prime = 500;

// TODO : Ajouter 100 à notre épargne (Yes !)
epargne += 100;

// TODO : Retirer 50 de notre budget courses (Oups !)
budgetCourses -= 50;


// TODO : Mettre à jour la durée d'épargne nécessaire pour atteindre l'objectif

int nombreDeMoisEpargneRestant = (objectifEpargne - epargne) / epargneParMois;

// TODO : Mettre à jour le budget courses (encore)

budgetCourses -= (30 - 10) * 7;

// Afficher le résultat
Console.WriteLine("Votre allocation courante est de " + allocationCourante);
Console.WriteLine("Le montant de votre épargne est de " + epargne);
Console.WriteLine("Nombres de mois avant l'achat de la moto  " + nombreDeMoisEpargneRestant);
Console.WriteLine("Vous bénéficiez d'une prime de " + prime);
Console.WriteLine("Votre budget pour les courses est de " +  budgetCourses);