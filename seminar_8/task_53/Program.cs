// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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



int[,] changeMatr(int[,] matrix)
{
    
    
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
          if (i == matrix.GetLength(0) - 1)
            {
            int temp = matrix[i, j];
            Console.WriteLine($" значение темп или матр до изменений={temp}");
            
            matrix[i, j] = matrix[i-i, j];
            Console.WriteLine($" значение матр после изменений ={matrix[i, j]}");
            matrix[i-i, j] = temp;
            
            }
        }
    }
    return matrix;
}



int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int [,] newMatrix = getMatrix(rows,columns,leftSide,rightSide);

printMatrix(newMatrix);

Console.WriteLine();

int [,] Changes = changeMatr(newMatrix);
printMatrix(Changes);



