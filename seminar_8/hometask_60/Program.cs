// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)






int[,,] getMatrix(int rowsCount,int columnsCount,int deepCount,int leftRange,int rightRange)
{
    int[,,] matr = new int[rowsCount,columnsCount,deepCount];
    Random rand = new Random();
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            for(int k=0;k<matr.GetLength(2);k++)
             {
              matr[i,j,k] = rand.Next(leftRange,rightRange);
             }
        }
         
   }
   return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void printMatrix(int[,,] matr)
{
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
        for(int k=0;k<matr.GetLength(2);k++)
        {
            Console.Write($"{matr[i,j,k]},({i},{j},{k})");

        }
        Console.WriteLine();
       }
     Console.WriteLine();
   }
}

int rows = GetNumber("Введите число патернов: ");
int columns = GetNumber("Введите число столбцов: ");
int deep = GetNumber("Введите глубину массива: ");
int leftSide = GetNumber("Введите левую границу числового диапазона: ");
int rightSide = GetNumber("Введите правую границу числового диапазона: ");

int [,,] newMatrix = getMatrix(rows,columns,deep,leftSide,rightSide);
printMatrix(newMatrix);

