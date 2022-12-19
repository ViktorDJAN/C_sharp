// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
Console.WriteLine("Введите размер матрицы");
int n = Convert.ToInt32(Console.ReadLine());
int[,] getMatrix(int n)
{
    int[,] matr = new int[n,n];
    int current = 1;
    for(int i=0;i<n/2;i++)
    {
        for(int j=0;j<n-i;j++)
        {
          matr[i,j] = current++;
        }
         for(int k = 0;k<n-i;k++)
         {
             matr[k,n-i-1]=current++;
         }
         for(int j = n-i-2;j>i;j--)
         {
            matr[n-i-1,j] = current++;
         }
             for(int k = n-1-i;k>i;k--)
         {
             matr[k,i]=current++;
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



int [,] newMatrix = getMatrix(n);
printMatrix(newMatrix);























