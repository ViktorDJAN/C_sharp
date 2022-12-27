
string[] Getarray(int[] num)
{
    string[] arr1 = new string[4];

    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine("enter text");
        arr1[i] = Console.ReadLine();

    }
    Console.WriteLine($"[{string.Join(",", arr1)}]");
    return arr1;
}


int[] arr1 = new int[0];
string[] a = Getarray(arr1);

int numsel = new Random().Next(0, 4);


string[] mainwork(string[] curr, string[] changed)
{
    string[] exp = new string[numsel];
    int rand = new Random().Next(0, curr.Length);

    for (int i = 0; i < numsel; i++)
    {
        string t = curr[rand];

        curr[rand] = curr[i];
        exp[i] = t;

    }

    return exp;
}
string[] exp = new string[0];
string[] array1 = mainwork(a, exp);
Console.WriteLine($"[{string.Join(",", array1)}]");

