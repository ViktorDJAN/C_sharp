// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем



int [] Getarray(int [] num)
{
    int [] arr1 = new int[8];             

    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine("enter num");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    Console.WriteLine($"[{string.Join(",", arr1)}]");
    return arr1;
}   
int [] arr1 = new int[0];
int [] a = Getarray(arr1);
 


//Console.WriteLine($"[{string.Join(",", arr1)}]");
// int Workplace(int num)
// {   
//     int sum = 0;
//     int remainder = 0;
//     for(int i = num; i>0; i=i/10)
//     {
//          remainder = i%10;
//          sum += remainder;
//     }
//     Console.WriteLine(sum);
//     return sum;
// }
// int num = EnterNum("ENTER NUM");
// int numm = Workplace(num);