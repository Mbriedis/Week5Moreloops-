// See https://aka.ms/new-console-template for more information
//mängus osaleb 2 mängijat -  arvuti(cpu) ja kasutaja (user)
//mõlemad viskavad täringuid
//programm kontrollib, kumb mängija viskas rohkem 
//mängija, kes viskab rohkem on võitja 
//täringuid visatakse 3 korda




Random rnd = new Random();
int userRandom;
int cpuRandom;
int cpuScore = 0;
int userScore = 0;
for (int i = 0; i < 3; i++)
{
    //arvuti vise
    cpuRandom = rnd.Next(1, 7);
    //kasutaja vise 
    userRandom = rnd.Next(1, 7);



    Console.WriteLine("vajuta nuppu et visata täring");
    Console.ReadKey();
    Console.WriteLine($"arvuti viskas {cpuRandom}. kasutaja viskas {userRandom}");
    if (cpuRandom < userRandom)
    {
        userScore++;
        Console.WriteLine("Kasutaja on roundi võitnud!");
    }
    else if (cpuRandom > userRandom)
    {
        Console.WriteLine("Arvuti on roundi võitnud.");
        cpuScore++;
    }
    else
    {
        Console.WriteLine("Round on viik!!!");
    }
}
if (cpuScore > userScore) { Console.WriteLine("Kaotasid mängu!"); }
else if (cpuScore < userScore) { Console.WriteLine("Võitsid mängu!"); }
else { Console.WriteLine("Mäng on Viik!"); }







