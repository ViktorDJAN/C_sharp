// напишите программу которая принимает на вход число
// а выдает сумму чисел
// 7 ->  28   or   4 --> 10

Console.WriteLine("Enter a number");
int numA = Convert.ToInt32(Console.ReadLine());
int result = 0;
for(int i = 0; i <= numA;i++)
{
    result = result + i;
}
Console.WriteLine(result);