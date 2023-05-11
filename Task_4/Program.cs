// Напишите программу, которая принимает на выход три числа и выдает максимальное из этих чисел

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int d = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max)
   {
    max = b;
   }
    
if (d > max)
    {
    max = d;
    }
Console.Write ("максимальное число: ");
Console.Write (max);

