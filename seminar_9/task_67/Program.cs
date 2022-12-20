// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int m  =456;
int numbers(int m)
{
    int sum = 0;
    if(m/10 ==0)
    {
        return m%10;
    }
    sum = numbers(m/10) + m%10;
    return sum;
}
int sum = numbers(m);
Console.WriteLine(sum);