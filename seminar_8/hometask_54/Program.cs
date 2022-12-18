// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8




int[,] getMatrix(int rowsCount,int columnsCount,int leftRange,int rightRange)
{
    int[,] matr = new int[rowsCount,columnsCount];
    Random rand = new Random();
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
        matr[i,j] = rand.Next(leftRange,rightRange);
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
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void sort(int [,] arr)
{
    for(int k = 0;k< arr.GetLength(0);k++)
    {
         for(int l = 0;l< arr.GetLength(1)-1;l++)
         {
            for(int i = 0;i< arr.GetLength(0);i++)
            {
                for(int j = 0;j< arr.GetLength(1)-1;j++)
                {
                    if(arr[i,j] > arr[i,j+1])
                    {
                        int temp = arr[i,j];
                        arr[i,j] = arr[i,j+1];
                        arr[i,j+1] = temp;
                    }
                }
            }
         }

    }
}





int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int [,] newMatrix = getMatrix(rows,columns,leftSide,rightSide);
printMatrix(newMatrix);
Console.WriteLine();
sort(newMatrix);
printMatrix(newMatrix);

