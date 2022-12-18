// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] getMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void printMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [] sort(int[,] arr)
{

   int [] res = new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
       
         
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
           sum = sum + arr[i,j];
           for(int r = 0; r<arr.GetLength(0);r++)
           {
            
           res[i] = sum;
           }
            
        }
        
        Console.WriteLine(sum);
      
    }
    return res;
     
}

int  GetDiference(int [] someArr)

{
    int indmin = 0;
    int minnum = someArr[0];
    for(int i = 0;i<someArr.Length;i++)
    {
   
        if(someArr[i]< minnum)  
        {
        minnum = someArr[i];
        indmin = i;
        }
    }  
    return indmin;
}  



int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int[,] newMatrix = getMatrix(rows, columns, leftSide, rightSide);
printMatrix(newMatrix);
Console.WriteLine();

int [] somAr = sort(newMatrix);
Console.WriteLine(string.Join(",", somAr));

 
int num = GetDiference(somAr);
Console.WriteLine($"Строка с наименьшей суммой элементов под номером - {num+1}");

