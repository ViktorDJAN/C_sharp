// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


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

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int [,] newMatrix = getMatrix(rows,columns,leftSide,rightSide);
printMatrix(newMatrix);

