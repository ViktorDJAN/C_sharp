
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());

int Method1(int number)
{
  int i = 0;
  while(number >0)
  {
     number = number/2;
     i+= 1;
     
  }
  return i;
}

int numb = Method1(number); // находим количество раз деления на 2.  при 8 будет 4   а при   5 ---- будет 3
Console.WriteLine($"dlina kolichestva deleni = {numb}");
int[] ost = new int [numb]; //создаем список длиной количества делений. numb.
int o = ost.Length-1;
Console.WriteLine($"dlina = {o}");
while(number>0)
{
    ost[o] = number%2;
    Console.WriteLine($"resultat = {ost[o]}");
    number = number/2;
    Console.WriteLine($"resultat deleni number = {number}");
    o = o-1;
}
Console.WriteLine(string.Join(",",ost));