// See https://aka.ms/new-console-template for more information
//programm küsib kasutajatunnust ja salasõna;
//kui sisestatud salasõna on "admin" ja salasõna on "admin1234"
//siis konsoolis kuvatakse "tere tulemast"
//muul juhul kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti" 
//kasutajal on 3 katset 
int i = 0;

while (i < 3) {
    Console.WriteLine("Sisesta kasutajatunnus");
    string userName = Console.ReadLine();
    Console.WriteLine("Sisesta saslasõna");
    string userPwd = Console.ReadLine();
    if
      (userName == "admin" && userPwd == "admin1234")
    { Console.WriteLine("Tere tulemast!");
    break; }
    else {
        i++;
        Console.WriteLine($"Vale kasutajatunnus või salasõna, {3 - i} katset on jäänud."); }
}
Console.WriteLine("kena päeva!");