        public class Utilisateur
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }

    public Utilisateur()
    {
        Nom = "";
        Prenom = "";
    }
    public Utilisateur(string prenom, string nom)
    {
        Nom = nom;
        Prenom = prenom;
    }
            public void Afficher()
    {
        System.Console.WriteLine($"Utilisateur : Je m'appelle {Prenom} {Nom}");
    }

        }

public class Admin : Utilisateur
{

}
public class Client : Utilisateur
{
    public Client()
    {
        Adresse = "";
    }
    public Client(string prenom, string nom, string adresse) : base(prenom, nom)
    {
        Adresse = adresse;
    }
    public string Adresse { get; set; }
    public new void Afficher()
    {
        System.Console.WriteLine($"Client : Je m'appelle {Prenom} {Nom} et j'habite à {Adresse}");
    }
}



public class Employe : Utilisateur
{
    public Employe()
    {
        Poste = "";
    }
    public Employe(string prenom, string nom, string poste) : base(prenom, nom)
    {
        Poste = poste;
    }
    public string Poste { get; set; }
    public new void Afficher()
    {
        System.Console.WriteLine($"Employé : Je m'appelle {Prenom} {Nom} et je travaille en tant que {Poste}");
    }
}

