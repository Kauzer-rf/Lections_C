// Условия
Console.Write("Введите имя юзера: ");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("Привет босс!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}