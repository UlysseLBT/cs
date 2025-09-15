//EX 1

for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

//EX 2
Console.WriteLine("Entrez un nombre :");
string input = Console.ReadLine();
int nombre = Convert.ToInt32(input);
int tablemultiplication = 0;
for (int i = 1; i <= 10; i++)
{
    tablemultiplication = nombre * i;
    Console.WriteLine($"{nombre} x {i} = {tablemultiplication}");
}

//EX 3
Console.WriteLine("Entrez un nombre :");
string input3 = Console.ReadLine();
int nombre3 = Convert.ToInt32(input3);
int somme = 0;
while (nombre3 != 0)
{
    somme += nombre3;
    Console.WriteLine("Entrez un nombre (0 pour terminer) :");
    input3 = Console.ReadLine();
    nombre3 = Convert.ToInt32(input3);
}
Console.WriteLine($"La somme des nombres est : {somme}");

//EX 4
Random rand = new Random();
int nombreAlea = rand.Next(1, 101); // Généré une seule fois

int nombre4;
do
{
    Console.WriteLine("Devinez le nombre entre 1 et 100 :");
    string input4 = Console.ReadLine();
    nombre4 = Convert.ToInt32(input4);

    if (nombre4 < nombreAlea)
    {
        Console.WriteLine("Trop petit !");
    }
    else if (nombre4 > nombreAlea)
    {
        Console.WriteLine("Trop grand !");
    }
    else
    {
        Console.WriteLine("Bravo, vous avez trouvé le nombre !");
    }

} while (nombre4 != nombreAlea);

//EX 5

string[] prenoms = { "Alice", "Bob", "Charlie", "Diana" };
foreach (string prenom in prenoms)
{
    Console.WriteLine(prenom);
}

//EX 6
//calculer et afficherla sommes des nombres du tableau
int[] nombres = { 3, 7, 2, 9, 4 };
int som = 0;
foreach (int nbr in nombres)
{
    som += nbr;
}
Console.WriteLine($"La somme des nombres est : {som}"); 