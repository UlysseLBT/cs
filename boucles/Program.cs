for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

int n = 0;
while (n < 5)
{
    Console.WriteLine(n);
    n++;
}

int m = 0;
do
{
    Console.WriteLine(m);
    m++;
} while (m < 5);

int[] tableau = { 1, 2, 3, 4, 5 };
foreach (int element in tableau)
{
    Console.WriteLine(element);
}

string[] chaines = { "un", "deux", "trois" };
foreach (string chaine in chaines)
{
    Console.WriteLine(chaine);
}

