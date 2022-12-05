// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

// СОЗДАЕМ МЕТОД ДЛЯ ВВОДА
int EnterNum(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// int numA = EnterNum("ENTER A");
// int numB = EnterNum("ENTER B");

// СОЗДАЕМ МЕТОД ОБРАБОТКИ
int Workplace(int numA , int numB)
{
    int res = 1;
    for(int i = 0; i<numB; i++)
    {
         res = res * numA;
    }
    Console.WriteLine(res);
    return res;
}
int numA = EnterNum("ENTER A");
int numB = EnterNum("ENTER B");
int numm = Workplace(numA, numB); //    А ВОТ ТУТ Я НЕ ПОНЯЛ , ЗАПУСТИЛ И ВСЕ ЗАРАБОТАЛО
                                  //    ХОТЕЛ ДОБАВИТЬ   CONSOLE.WRITELINE  А ЧИСЛО УЖЕ ВЫВЕЛОСЬ САМО

                                  //    НЕ МОГЛИ БЫ ЧУТЬ ЧУТЬ ПОЯСНИТЬ ЭТО МОМЕНТ  ??? 
