Console.Write("Obtenir les X nombres premiers \n> ");
int nbCount = int.Parse(Console.ReadLine()!);

List<int> nbPrimes = new List<int>();
int nbCountOp = 0;

if(nbCount > 1)
{
    nbPrimes.Add(2);
}

for(int nbCurrent = 3; nbPrimes.Count < nbCount; nbCurrent += 2)
{
    bool isPrime = true;

    for (int i = 0; isPrime && nbPrimes[i] < Math.Sqrt(nbCurrent) ; i++)
    {
        nbCountOp++;
        if (nbCurrent % nbPrimes[i] == 0)
        {
            isPrime = false;
        }
    }

    if(isPrime)
    {
        nbPrimes.Add(nbCurrent);
    }
}

Console.WriteLine("Liste des nombres premiers : ");
Console.WriteLine(string.Join(" > ", nbPrimes));

Console.WriteLine($"Nb operation : {nbCountOp}");