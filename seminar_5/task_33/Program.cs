//    Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//    4; массив [6, 7, 19, 345, 3] -> нет
//    3; массив [6, 7, 19, 345, 3] -> да 
//    ТОЛЬКО одно сообщение: либо "да", либо "нет".


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int [] Getarray(int size,int leftside,int rightside)
{
    int [] array = new int[size];
    Random rand = new Random();
    for(int i = 0;i < size; i++)
    {
        array[i] = rand.Next(leftside,rightside);
    }
    return array;
}

const int SIZE = 5;
const int LEFTSIDE = 1;
const int RIGHTSIDE = 9;

int [] newArray = Getarray(SIZE,LEFTSIDE,RIGHTSIDE);
Console.WriteLine(string.Join(",",newArray));


string word = "";
for(int i = 0; i < newArray.Length;i++)
{
    
    if(num == newArray[i])
    {
        word = "ДА";
    }
    else
    {
        word = "НЕТ";
    }

}
Console.WriteLine($"Есть ли заданное число в массиве? {word}");