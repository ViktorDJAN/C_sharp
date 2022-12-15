// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет





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

Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

int searchedNum(int[,] dualarray)
{   
    int tet = 0;
    for (int i = 0; i < dualarray.GetLength(0); i++)
    {
        for (int j = 0; j < dualarray.GetLength(1); j++)
        {
           if (dualarray[i, j] == number) tet =dualarray[i, j];
        
         
        }
    }
    return tet;
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

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int[,] newMatrix = getMatrix(rows, columns, leftSide, rightSide);
printMatrix(newMatrix);
int newnum = searchedNum(newMatrix);

if (newnum == 0) 
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine($"Искомое число равно {newnum}");
}


