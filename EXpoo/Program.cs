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

        // Affichage des infos
        compte.Afficher();
    }
}
