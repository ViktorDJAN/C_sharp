// напишите программу которая принимает на вход число
// а выдает сумму чисел
// 7 ->  28   or   4 --> 10

bool validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}


int coun (int A)
{
    int result = 0;
    for(int i = 0; i <=  A;i++)
    {
        result = result + i;
    }
    return result;
}

int getNumber(string message)
{
    Console.WriteLine("ENTER NUMBER");
    int numA = Convert.ToInt32(Console.ReadLine());
    return numA;
}
// FUNCTION APPLICATION AND USAGE!!

int number = getNumber("ENTER A NUMBER");
bool isCorrect = validate(number);
if (isCorrect == true)
{
    int sum = coun(number);
    Console.WriteLine(sum);
}