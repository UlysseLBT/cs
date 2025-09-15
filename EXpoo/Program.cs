using System;

class Program
{
    static void Main(string[] args)
    {
        // Création d’un titulaire
        Titulaire titulaire = new Titulaire
        {
            Id = 1,
            Nom = "Durand",
            Prenom = "Alice",
            Adresse = "15 rue Victor Hugo",
            CodePostal = "75001",
            Ville = "Paris",
            Tel = "0601020304",
            Email = "alice.durand@email.com"
        };

        // Création d’un compte
        Compte compte = new Compte(1500m, titulaire);

        // Affiche le compte initial
        compte.Afficher();

        // On crédite 500 €
        compte.Crediter(500);
        compte.Afficher();

        // On débite 300 €
        compte.Debiter(300);
        compte.Afficher();

        // Tentative de débit supérieur au solde
        compte.Debiter(3000);
        compte.Afficher();

        Console.WriteLine("\n============================\n");

        // Création d’un tableau de prénoms
        string[] prenoms = { "Alice", "Bob", "Claire", "David", "Emma" };

        // Affichage avec foreach
        Console.WriteLine("--- Liste des prénoms ---");
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }
    }
}
