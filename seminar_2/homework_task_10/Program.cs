// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100,1000);

int numA = number / 100;
int numB = (number - numA * 100)/10 ;
Console.WriteLine(number);
Console.WriteLine(numA);
Console.WriteLine(numB);