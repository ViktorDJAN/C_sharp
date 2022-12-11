// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



// ------ВОПРОС-------
// Хотел сделать задачу по своему , но почему пока не получается
// Подскажите пожалуйста , где тут ошибка , что  я не правильно делаю !


int [] GetArraynum(int [] num)
{
    Console.WriteLine("enter size of side");
    int [] arr1 = new int[3];
    for(int i = 0;i< arr1.Length;i++)
    {
        arr1[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr1;
}
int[] arr1 = new int[3];
int[] Newarray = GetArraynum(arr1);
Console.WriteLine(string.Join(",",Newarray));

string Answer(int [] requiered)
{    
    string a1 ="";
    for(int i = 0;i< requiered.Length;i++)
    {
        if(arr1[0] < arr1[1]+arr1[2] && arr1[1] < arr1[0]+arr1[2] && arr1[2] < arr1[1]+arr1[0])
        {
             a1 = "triangle is good and may exist";
        }
        else
        {
            a1 = "no";
        }
        
    }   
    return a1;
}
string newanswer = Answer(Newarray);
Console.WriteLine(newanswer);


// // ЭТОТ ВАРИАНТ РАБОТАЕТ!!!
// string a1 = "";
// int [] req = {3,4,35};
// for(int i = 0;i< req.Length;i++)
// {
//     if(req[0] < req[1]+req[2] && req[1] < req[0]+req[2] && req[2] < req[1]+req[0])
//     {
//         a1 = "triangle MAY exist";
//     }
//     else
//     {
//         a1 = "no";
//     }
// }        
// Console.WriteLine(a1);