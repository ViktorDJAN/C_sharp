// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
    int Countsum = 0;
    for(int i = 0;i<someArr.Length;i++)
    {
   
        if(i%2 !=0)
       {
          Countsum +=someArr[i];
       }
    }  
    return Countsum;
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
Console.WriteLine($" The sum of numbers  on even positions = {Quantity}");