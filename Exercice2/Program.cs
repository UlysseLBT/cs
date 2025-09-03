Console.WriteLine("Exercice 2");

int note = 0;
if (note >= 10)
{
    Console.WriteLine("Admis");
}
else
{
    Console.WriteLine("Non admis");
}

switch (note)
{
    case >= 15:
        Console.WriteLine("Très bien");
        break;
    case >= 10:
        Console.WriteLine("Bien");
        break;
    case >= 5:
        Console.WriteLine("Moyen");
        break;
    default:
        Console.WriteLine("Insuffisant");
        break;
}


int Pierre = 12;
int Paul = 14;
if (Pierre > Paul)
{
    Console.WriteLine("Pierre est plus âgé que Paul.");
}
else if (Pierre < Paul)
{
    Console.WriteLine("Paul est plus âgé que Pierre.");
}
else
{
    Console.WriteLine("Pierre et Paul ont le même âge.");
}

switch (Pierre - Paul)
{
    case > 0:
        Console.WriteLine("Pierre est plus âgé que Paul.");
        break;
    case < 0:
        Console.WriteLine("Paul est plus âgé que Pierre.");
        break;
    case 0:
        Console.WriteLine("Pierre et Paul ont le même âge.");
        break;
}