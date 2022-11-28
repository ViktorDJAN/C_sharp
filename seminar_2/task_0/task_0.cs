// Напишите программу которая выводит случайное число из 
// отрезка [10,99] и показывает наибольшую цифру числа.
// например 78 -> 8  если 12 -> 2.

int number = new Random().Next(10, 100);
int digit2 = number % 10;
int digit1 = number / 10;
Console.WriteLine(number);

if(digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
   Console.WriteLine(digit2); 
}