//   Задача 32: Напишите программу замена элементов массива: 
//   положительные элементы замените на соответствующие отрицательные, и наоборот.
//   [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
int [] rotation(int [] somearray)
{    
    for(int i =0;i < somearray.Length; i+= 1)
    if(somearray[i]>0)
    {
    somearray[i] = -somearray[i];
    }
    else
    {
        somearray[i] = -somearray[i];
    }
    return somearray;
}
const int SIZE = 10;
const int RIGHTRANGE = 10;
const int LEFTRANGE = -10;


int [] newARR = Getarray(SIZE,LEFTRANGE,RIGHTRANGE);
Console.WriteLine($"Входной массив первые значения -> [{string.Join(',',newARR)}]");
int [] rArr = rotation(newARR);
Console.WriteLine($"Массив с обратными значениями --> [{string.Join(',',rArr)}]");
