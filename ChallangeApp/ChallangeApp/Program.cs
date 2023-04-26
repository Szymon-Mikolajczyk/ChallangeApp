var name = "Ewa";
var age = 33;
char sex = 'F'; // F - kobieta, M - mężczyzna

if (sex == 'F')
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33.");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");
    }
    else
    {
        Console.WriteLine("Kobieta lat 30 lub więcej.");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna.");
}
