// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

void numA (int num)
{
    if(num ==0)
    {
        return;
    }
    else
    {
        Console.Write(num + " ");
        numA(num-1);
       
    }

}
numA(num);