// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​
// Например, изначально массив               Новый массив будет выглядеть
// выглядел вот так:                         вот так:
// 1 4 7 2                                   1 4 7 2
// 5 9 2 3                                   5 81 2 9
// 8 4 2 4                                   8 4 2 4



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

int [,] squareMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
           if(i%2==0 && j%2==0)matrix[i,j] = matrix[i,j]*matrix[i,j]; 
        }
    }
    return matrix;
}

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int [,] newMatrix = getMatrix(rows,columns,leftSide,rightSide);
Console.WriteLine("Двумерный массив до изменений");
printMatrix(newMatrix);
Console.WriteLine();

int[,] squre = squareMatrix(newMatrix);
Console.WriteLine("Двумерный массив после изменений");
printMatrix(squre);



