// See https://aka.ms/new-console-template for more information
//programm küsib kasutajatunnust ja salasõna;
//kui sisestatud salasõna on "admin" ja salasõna on "admin1234"
//siis konsoolis kuvatakse "tere tulemast"
//muul juhul kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti" 

//OR (Või) || Pipes 
//true || true --> true
//false || true --> true
//true || false --> true
//false || false --> false

Console.WriteLine("Sisesta kasutajatunnus");
string userName = Console.ReadLine();
Console.WriteLine("Sisesta saslasõna");
string userPwd = Console.ReadLine();

if (userName == "admin" || userPwd == "admin1234")
{ Console.WriteLine("Tere tulemast!"); }
else
{ Console.WriteLine("Vale kasutajatunnus või salasõna, proovi uuesti"); }