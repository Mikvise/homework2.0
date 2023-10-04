int number = ReadInt("Я жду число, но не меньше трёхзначного!");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Я же просил трёхзначное число. Ну а так, остаётся только; ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}