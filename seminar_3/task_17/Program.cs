// Напишите программу которая принимает на вход две координатные точки (Х и У) х не равен нули и у также не равен нулю
// программа выдает номер четверти в которой находятся эта точка

Console.WriteLine("Введите координату X ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}