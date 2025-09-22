        public class Utilisateur
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }

            public void Afficher()
            {
                System.Console.WriteLine($"Je m'appelle {Prenom} {Nom}");
            }

        }