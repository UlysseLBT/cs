using System;

public class Compte
{
    private decimal solde;

    public decimal Solde
    {
        get { return solde; }
        set
        {
            if (value >= 0)
                solde = value;
            else
                throw new ArgumentException("Le solde ne peut pas être négatif.");
        }
    }

    public Titulaire Titulaire { get; set; }

    public Compte(decimal soldeInitial, Titulaire titulaire)
    {
        Solde = soldeInitial;
        Titulaire = titulaire;
    }

    public void Afficher()
    {
        Console.WriteLine($"--- Informations du compte ---");
        Console.WriteLine($"Solde du compte : {Solde} €");
        Console.WriteLine($"Titulaire : {Titulaire.Prenom} {Titulaire.Nom}");
        Console.WriteLine($"Adresse : {Titulaire.Adresse}, {Titulaire.CodePostal} {Titulaire.Ville}");
        Console.WriteLine($"Téléphone : {Titulaire.Tel}");
        Console.WriteLine($"Email : {Titulaire.Email}");
    }
}
