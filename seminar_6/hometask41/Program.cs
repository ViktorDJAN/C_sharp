// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("enter  array SIZE");
 int NUM = Convert.ToInt32(Console.ReadLine());
int [] Getarray(int [] num)
{
    
    int [] arr1 = new int[NUM];             
    string stop = "-01221";
    int.TryParse(stop,out int result);
    int counter = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine("enter num");
        arr1[i] = Convert.ToInt32(Console.ReadLine()); 
        if(arr1[i] >0) counter++;
        if(arr1[i] == result) break;
    }
        
    Console.WriteLine($"[{string.Join(",", arr1)}]");
    Console.WriteLine($"sum of numbers more than zero = {counter}");
    return arr1;
}
int [] arr1 = new int[0];
int [] a = Getarray(arr1);


