//   Задача 38: Задайте массив натуральных чисел. 
//   Найдите разницу между максимальным и минимальным элементов массива.

//   [3 7 22 2 78] -> 76

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
int  GetDiference(int [] someArr)

{
    int maxnum = 0;
    int Diference = 0;
    int minnum = someArr[0];
    for(int i = 0;i<someArr.Length;i++)
    {
   
        if(someArr[i]< minnum)  minnum = someArr[i];
        if(someArr[i]> maxnum)  maxnum = someArr[i];
        
       
        Diference = maxnum - minnum;
       
    }  
    return Diference;
}   

Console.WriteLine("Enter an array size");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an array leftrange");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an array rightrange");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] newAR = Getarray(size,leftRange,rightRange);
Console.WriteLine(string.Join(",",newAR));

int Quantity = GetDiference(newAR);
Console.WriteLine($" The diference of numbers between max and min  = {Quantity}");