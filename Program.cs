using System;

namespace Additionner
{
    class Program
    {
        // Méthode principale de l’application.
        static void Main(string[] args)
        {
            // Section de déclaration des variables
            int Nombre_1, Nombre_2, Nombre_3, Total;

            // Saisie du premier nombre.
            Console.Write("Donnez-moi le premier nombre entier : ");
            Nombre_1 = Convert.ToInt32(Console.ReadLine());

            // Saisie du deuxième nombre.
            Console.Write("Donnez-moi le deuxième nombre entier : ");
            Nombre_2 = Convert.ToInt32(Console.ReadLine());

            // Saisie du troisième nombre.
            Console.Write("Donnez-moi le troisième nombre entier : ");
            Nombre_3 = Convert.ToInt32(Console.ReadLine());

            // Opération d’addition.
            Total = Nombre_1 + Nombre_2 + Nombre_3;

            // Affichage du résultat et fin du programme.
            Console.WriteLine(Nombre_1 + " + " + Nombre_2 + " + " + Nombre_3 + " = " + Total);

            Console.ReadKey();
        }
    }
}


//je n'avait pas pu trouver mon erreur qui ce situer dans la dernière ligne Console.writeLine(... total, ect.) J'ai donc utiliser tchatgpt-
//qui lui à corriger:

//J'ai corrigé les points suivants :
//1. Suppression des espaces avant et après les tirets dans les messages de demande pour uniformiser le style d'écriture.
//2. Modification de la méthode de conversion de `ToInt16` à `ToInt32` pour éviter toute perte de données en cas de saisie de nombres plus grands.
//3. Correction du code 
//using System;
//namespace Additionner
//{
    //class Program
    //{
        // Méthode principale de l’application.
        //static void Main(string[] args)
        //{
            // Section de déclaration des variables
           // int Nombre_1, Nombre_2, Nombre_3, Total;
            // Saisie du premier nombre.
          //  Console.Write("Donnez - moi le premier nombre entier: ");
          //  Nombre_1 = Convert.ToInt16(Console.ReadLine());
            // Saisie du deuxième nombre.
          //  Console.Write("Donnez - moi le deuxième nombre entier: ");
          //  Nombre_2 = Convert.ToInt16(Console.ReadLine());
            // Saisie du troisième nombre.
          //  Console.Write("Donnez - moi le troisième nombre entier: ");
          //  Nombre_3 = Convert.ToInt16(Console.ReadLine());
            // Opération d’addition.
         //   Total = Nombre_1 + Nombre_2 + Nombre_3;
            // Affichage du résultat et fin du programme.
          //  Console.WriteLine("Nombre_1+ "+" +Nombre_2+ "+ " +Nombre_3+ "="+Total");
             //   Console.ReadKey();
     //   }
  //  }
//}
//ligne 66 avait une erreur que je ne trouver pas..