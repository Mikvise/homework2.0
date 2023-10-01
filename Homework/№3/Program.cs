Console.WriteLine("Введите одно число");
int A = int.Parse(Console.ReadLine());
int B = A % 2;
if (B == 0)
{
    Console.WriteLine("Число " + A + " делится на 2 без остатка");
}
else
{
    Console.WriteLine("Число " + A + " не делится на 2 без остатка");
}