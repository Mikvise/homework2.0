﻿Console.WriteLine("Нам понадобится от вас 2 числа,");
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("Число " + A + " большее");
    Console.Write("Число " + B + " меньшее");
}
else if (A == B)
{
    Console.WriteLine("Число " + A + " и число " + B + " равны ");
}
else
{
    Console.WriteLine("Число " + B + " большее");
    Console.Write("Число " + A + " меньшее");
}