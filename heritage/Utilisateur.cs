        public class Utilisateur
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }

    public Utilisateur()
    {
        Nom = "";
        Prenom = "";
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
    public string Poste { get; set; }
    public new void Afficher()
    {
        System.Console.WriteLine($"Employé : Je m'appelle {Prenom} {Nom} et je travaille en tant que {Poste}");
    }
}

