// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int [,] resultat(int[,] matr1, int[,] matr2)
{
    int [,] matr = new int [matr1.GetLength(0),matr1.GetLength(1)];
    if(matr1.GetLength(0)==matr2.GetLength(0) && matr1.GetLength(0)==matr2.GetLength(1))
    {
    for(int i=0;i<matr1.GetLength(0);i++)
      {
        for(int j=0;j<matr1.GetLength(1);j++)
        {
            matr[i,j] = matr1[i,j] * matr2[i,j];
        }
      }
    }
    return matr;
}



int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int [,] matr1= getMatrix(rows,columns,leftSide,rightSide);
printMatrix(matr1);
Console.WriteLine();
int [,] matr2= getMatrix(rows,columns,leftSide,rightSide);
printMatrix(matr2);
Console.WriteLine();
Console.WriteLine("произведение матриц будет равно следующему массиву:");
int [,] bigMatr = resultat(matr1,matr2);
printMatrix(bigMatr);


