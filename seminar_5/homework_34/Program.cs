//    Задача 34: Задайте массив заполненный случайными положительными т
//    рёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//    [345, 897, 568, 234] -> 2

int[] Getarray(int size, int leftRange, int rightRange)
{
    int [] array = new int[size];
    Random rand = new Random();
    
    for(int i =0;i < array.Length; i+= 1)
    {
        array[i] = rand.Next(leftRange,rightRange+1);
    }
    return array;
}
int  GetEvenNum(int [] someArr)

{
    int Count = 0;
    for(int i = 0;i<someArr.Length;i++)
    {
   
        if(someArr[i]%2 ==0)
       {
          Count +=1;
       }
    }  
    return Count;
}   

Console.WriteLine("Enter an array size");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an array leftrange");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an array rightrange");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] newAR = Getarray(size,leftRange,rightRange);
Console.WriteLine(string.Join(",",newAR));

int Quantity = GetEvenNum(newAR);
Console.WriteLine($" Quantity of even numbers = {Quantity}");