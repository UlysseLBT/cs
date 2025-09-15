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

    // Méthode pour créditer le compte
    public void Crediter(decimal montant)
    {
        if (montant > 0)
            Solde += montant;
        else
            Console.WriteLine("Le montant à créditer doit être positif.");
    }

    // Méthode pour débiter le compte
    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant à débiter doit être positif.");
        }
        else if (montant > Solde)
        {
            Console.WriteLine("Fonds insuffisants, opération refusée.");
        }
        else
        {
            Solde -= montant;
        }
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
