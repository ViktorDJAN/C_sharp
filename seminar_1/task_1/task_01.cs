Console.WriteLine("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double numberB = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Math.Pow(number,2));
if(numberA == Math.Pow(numberB,2))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}