// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.   m = 2, n = 3 -> A(m,n) = 9


int m = 2;
int n = 3;


int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akk(m - 1, 1);
    if( m>0 && n >0) return Akk(m - 1, Akk(m, n - 1));
    return Akk(m,n);
  
}

Console.WriteLine($" {Akk(m, n)}");
