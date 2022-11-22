//  Задача 4: Напишите программу, которая принимает на вход
//  три числа и выдает максимальное из этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}
Console.WriteLine("Max = " + max);