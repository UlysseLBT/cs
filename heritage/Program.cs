namespace Heritage
{
    public class Heritage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Heritage c#");
            Utilisateur user = new Utilisateur();
            user.Nom = "Lebouteiller";
            user.Prenom = "Ulysse";
            user.Afficher();

            Client client = new Client();
            client.Nom = "Dupont";
            client.Prenom = "Jean";
            client.Adresse = "10 rue des lilas";
            client.Afficher();

            Employe employe = new Employe();
            employe.Nom = "Durand";
            employe.Prenom = "Paul";
            employe.Poste = "Développeur";
            employe.Afficher();
        }
    }
}

