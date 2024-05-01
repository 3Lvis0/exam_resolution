using System;

class Program
{
    static void Main(string[] args)
    {
        // Déclaration des variables pour la température maximale, minimale et moyenne.
        int Temperature_Max, Temperature_Min;
        double Temperature_Moyenne;

        // Demande à l'utilisateur de saisir la température maximale de la journée.
        Console.Write("Donnez-moi la température maximale de la journée : ");
        // Saisie de la température maximale et enregistrement dans la variable.
        Temperature_Max = Convert.ToInt32(Console.ReadLine());

        // Demande à l'utilisateur de saisir la température minimale de la journée.
        Console.Write("Donnez-moi la température minimale de la journée : ");
        // Saisie de la température minimale et enregistrement dans la variable.
        Temperature_Min = Convert.ToInt32(Console.ReadLine());

        // Calcul de la température moyenne de la journée.
        Temperature_Moyenne = (Temperature_Max + Temperature_Min) / 2.0;

        // Affichage du résultat de la température moyenne.
        Console.WriteLine("La température moyenne de la journée a été de : " + Temperature_Moyenne);
        
        // Attente de l'appui sur une touche avant de fermer la console.
        Console.ReadKey();
    }
}
