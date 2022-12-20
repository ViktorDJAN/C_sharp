// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m  =5;
int numbers(int m)
{
    int sum = 0;
    if(m ==0)
    {
        return m;
    }
    sum = numbers(m-1) + m;
    
    return sum;
}
int sum = numbers(m);
Console.WriteLine(sum);