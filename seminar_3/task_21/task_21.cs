// Напишите программу которая находит расстояние между тремя координатными точками
// в 3D пространстве.

Console.WriteLine("Введите перую координату Xa и Ya");
double xa = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату Xb и Yb");
double xb = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());

//double distant = Math.Sqrt((xa-xb) нахождение корня
//Console.WriteLine(Math.Pow(xa, 2)) нахождение квадрата от числа

double distant = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb - ya),2));
Console.WriteLine(distant);