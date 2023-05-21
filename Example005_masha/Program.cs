Console.Write("Text your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Huzzah, it is a Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}