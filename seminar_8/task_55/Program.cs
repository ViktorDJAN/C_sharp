
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int[,] getMatrix(int rowsCount,int columnsCount,int leftRange,int rightRange)
{
    int[,] matr = new int[rowsCount,columnsCount];
    Random rand = new Random();
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
        matr[i,j] = rand.Next(leftRange,rightRange+1);
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
void Toexecute (int [,] currentMatr, int [,] changedMatr)
{
    for(int i=0;i<currentMatr.GetLength(0);i++)
    {
        for(int j=0;j<currentMatr.GetLength(1);j++)
        {        
            changedMatr[i,j] = currentMatr[j,i];

        }
    }
    
}




int [,] newMatrix = getMatrix(rows,columns,leftSide,rightSide);
printMatrix(newMatrix);
Console.WriteLine();
int[,] changedMatrix = new int [rows, columns];


if(rows!=columns) 
{
    Console.WriteLine("impossible to ctreate matrix");
}
else
{
Toexecute(newMatrix,changedMatrix);
printMatrix(changedMatrix);
}







