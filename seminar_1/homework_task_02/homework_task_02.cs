//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Math.Pow(number,2));
if(numberA > numberB)
{
    Console.Write("max = " + numberA);
    Console.Write(", ");
    Console.WriteLine("min = " + numberB);
}
else
{
    Console.Write("max = " + numberB);
    Console.Write(", ");
    Console.WriteLine("min = " + numberA);
}
