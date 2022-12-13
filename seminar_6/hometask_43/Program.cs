// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = 2; double k1 = 5; double b2 = 4; double k2 = 9 ;

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;


Console.WriteLine($"The required cross point is equal {(x,y)}");