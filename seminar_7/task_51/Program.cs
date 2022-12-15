// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный



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
    int sum = 0;
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
           if(i==j) sum = sum + matrix[i,j]; 
        }
    }
    Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");
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



