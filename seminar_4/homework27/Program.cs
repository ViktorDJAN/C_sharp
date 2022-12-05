// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int EnterNum(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// int num = EnterNum("ENTER NUM");


// for (i = number; i > 0; i = (i / 10))
// {
//     remainder = i % 10;
//     newnum += remainder;
    
// }

// СОЗДАЕМ МЕТОД ОБРАБОТКИ
int Workplace(int num)
{   
    int sum = 0;
    int remainder = 0;
    for(int i = num; i>0; i=i/10)
    {
         remainder = i%10;
         sum += remainder;
    }
    Console.WriteLine(sum);
    return sum;
}
int num = EnterNum("ENTER NUM");
int numm = Workplace(num);