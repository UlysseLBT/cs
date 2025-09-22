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
        }
    }
}

