Console.Write("Obtenir les nombres premiers jusqu'à \n> ");
int nbLimit = int.Parse(Console.ReadLine()!);

List<int> nbPrimes =  new List<int>();
int nbCountOp = 0;

int nbCurrent = 2;
while(nbCurrent <= nbLimit)
{
    bool isPrime = true;
    int nbDiv = 2;

    while (isPrime && nbDiv <= (nbCurrent/2))
    {
        nbCountOp++;
        if (nbCurrent % nbDiv == 0)
        {
            isPrime = false;
        }
        nbDiv++;
    }

    if(isPrime)
    {
        nbPrimes.Add(nbCurrent);
    }
    nbCurrent++;
}


Console.WriteLine("Liste des nombres premiers : ");
Console.WriteLine(string.Join(" > ", nbPrimes));

Console.WriteLine($"Nb operation : {nbCountOp}");