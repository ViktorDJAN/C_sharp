// применение индекса. usage index.
int[] array = { 1, 23, 32, 24, 15, 64, 72, 89 };

int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index += 1;
}