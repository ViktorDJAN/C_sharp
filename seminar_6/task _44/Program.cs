// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3

int n = 9;
int [] name = new int[n];
name[0] = 0;
name[1] = 1;
for(int i = 2; i<n;i++) 
{
   name[i] = name[i-2]+ name[i-1];
   Console.WriteLine(name[i]);
}
Console.WriteLine(string.Join(",",name));

