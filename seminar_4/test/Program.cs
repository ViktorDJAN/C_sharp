Console.WriteLine("Введити длину массива");
int len = Convert.ToInt32(Console.ReadLine());

int [] array = new int[len];


int lenght = array.Length;
int index = 0;
 while(index < lenght)
{
    array[index] = new Random().Next(0,2);
    index += 1;
}
Console.WriteLine($"[{string.Join(",",array)}]");

