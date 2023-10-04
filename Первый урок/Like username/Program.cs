Console.Write("Как тебя зовут?");
string username = Console.ReadLine();

if(username.ToLower() == "игорюня")
{
    Console.WriteLine("Здарова, заебал. Чертила!");

}

else
{
    Console.Write("Здарова, ");
    Console.WriteLine(username);
}