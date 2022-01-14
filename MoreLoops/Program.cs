// See https://aka.ms/new-console-template for more information
//programm küsib kasutajatunnust ja salasõna;
//kui sisestatud salasõna on "admin" ja salasõna on "admin1234"
//siis konsoolis kuvatakse "tere tulemast"
//muul juhul kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti" 
Console.WriteLine("Sisesta kasutajatunnus");
string userName = Console.ReadLine();
Console.WriteLine("Sisesta saslasõna");
string userPwd = Console.ReadLine();
//AND (&&) 
//"admin" AND "admin1234" --> true
//"admin1" AND "admin1234" --> false
//"admin" AND "admin12345" --> false
//"admin1" AND "admin123" --> false


if (userName == "admin" && userPwd == "admin1234")
{ Console.WriteLine("Tere tulemast!"); }
else
{ Console.WriteLine("Vale kasutajatunnus või salasõna, proovi uuesti"); }