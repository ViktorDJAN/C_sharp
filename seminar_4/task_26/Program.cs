// Напишите программу которая принимает  
// на вход число и выдает количество цифр в числе.
//456 ->  3
//  4241 --> 4



int Numsearch(int num)
{
    int i = 0;
    int counter = 0;
    for(i = num ;i >0; i = i/ 10)
    {
        counter++;
    }
    Console.WriteLine(counter);
    return counter;
}

int getNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = getNumber("Введите число: ");
Numsearch(number);





