﻿// Напишите программу, которая на вход приинимает число и выдает, является ли число четным (делится ли оно на два без остатка)

Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
   {
    Console.WriteLine ("введенное число является четным");
   }
else 
{
    Console.WriteLine ("введенное число является нечетным");
}