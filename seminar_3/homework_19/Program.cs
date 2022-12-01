// напишите программу которая принимает на вход число N  и проверяет его на полиндромность
// 23432 да   145668  нет


int i = 0 , remainder = 0 ;
string newnum ="";
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//for (int i = 0 ; i < number+1 ; i+= 1)
for (i = number; i > 0; i = (i / 10))
{
    remainder = i % 10;
    newnum += remainder;
    
}
int NUM = Convert.ToInt32(newnum);
if (number == NUM)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
