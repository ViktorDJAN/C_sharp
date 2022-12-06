// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int [] newar = new int[12];
int sumpositiv = 0;
int sumnegativ = 0;
for(int i =0;i < newar.Length;i++)
{
    newar[i] = new Random().Next(-9,9);
    if(newar[i]<0)
    {
        sumpositiv += newar[i];
    }
    else
    {
        sumnegativ += newar[i];
    }
}
Console.WriteLine(string.Join(",",newar));
Console.WriteLine($"Сумма положительных чисел равна: {sumpositiv}");
Console.WriteLine($"Сумма положительных чисел равна: {sumnegativ}");
