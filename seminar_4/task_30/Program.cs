// напишите программу которая выводит
// массив из 8 элементов заполненый нулями 
// и единицами в случайном порядке.
//[1,1,1,1,0,0,0,0]

Console.WriteLine("Введити длину массива");
int len = Convert.ToInt32(Console.ReadLine());

int [] array = new int[len];

void Fillnull(int [] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(0,2);
        index += 1;
    }
}

void PrintArray(int[] someAr)
{
    int count = someAr.Length;
    int begining = 0;
    while(begining < count)
    {
        Console.WriteLine(someAr[begining]);
        begining += 1;
    }
}
Fillnull(array);
PrintArray(array);
