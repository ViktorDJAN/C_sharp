// напишите программу которая принимает на вход число N  и выдает таблицу квадратов от 1 до N
// 5    ---->  1 , 4, 9 ,  16 , 25.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1 ; i < number + 1; i+= 1)
{
    Console.WriteLine(i*i);
}



