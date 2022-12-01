// напишите программу которая принимает на вход число N  и выдает таблицу кубов от 1 до N
// 2    ---->  1 , 8....
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1 ; i < number + 1; i+= 1)
{
    Console.WriteLine(Math.Pow(i,3));
}
