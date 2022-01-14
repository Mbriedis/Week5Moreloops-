// See https://aka.ms/new-console-template for more information
//programm küsib kasutajal sisestada 3 numbrit;
//programm kuvab nende numbrite summat;
int sum = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("sisesta number");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    sum=sum+userNumber;
}
Console.WriteLine($"Your total sum is:{sum}");