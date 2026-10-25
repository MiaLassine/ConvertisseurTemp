//Programme : Exercice conversation de température
//Creator : Mia Lassine 107B
//Date : 25/10/2026

namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        Console.WriteLine("Entrez le nombre de votre choix :");
        Console.WriteLine("------------------------------------------------------------------");

        string stringUserNumber = Console.ReadLine();
        float floatUserNumber = float.Parse(stringUserNumber);
        Console.WriteLine("------------------------------------------------------------------");

        Console.WriteLine("Veuillez choisir l'unité de votre choix.");
        Console.WriteLine("Entrez 1 pour Celsius");
        Console.WriteLine("Entrez 2 pour Fahrenheit");
        Console.WriteLine("------------------------------------------------------------------");

        string stringUserChoice = Console.ReadLine();
        int intUserChoice = Convert.ToInt32(stringUserChoice);
        Console.WriteLine("------------------------------------------------------------------");

        if(intUserChoice == 1)
        {
            Console.WriteLine("Nombre en Celsius : " + floatUserNumber);
            floatUserNumber = (floatUserNumber * 9 / 5) + 32;
            Console.WriteLine("Nombre en Fahrenheit : " + floatUserNumber);
            Console.WriteLine("------------------------------------------------------------------");
        }
        else if(intUserChoice == 2)
        {
            Console.WriteLine("Nombre en Fahrenheit : " + floatUserNumber);
            floatUserNumber = (floatUserNumber - 32) * 5 / 9;
            Console.WriteLine("Nombre en Celsius : " + floatUserNumber);
            Console.WriteLine("------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("Erreur lors de l'encodage.");
        }
    }
}