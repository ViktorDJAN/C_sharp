﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Сначала просто считываете строку, если строка != "стоп", то делаете конвертацию)
// В 41 задаче внутри цикла Console.ReadLine() нужно вызывать только один раз. А у вас два раза) Console.ReadLine() в условии цикла, и в TryParse.
//  Можно сначала получать строку, затем строку сравнивать со stop, и если не равно, то пытаться конвертировать в
int counter = 0;

while(Console.ReadLine()!="stop" )
{
    Convert.ToInt32(Console.ReadLine());
    counter++;
}
Console.WriteLine(counter);

// есть некоторые проблемы , первое  если число введеных чисел больше двух то стоп нужно вводить два раза
//                         второе   код считает количество подобных чисел , если вводит два раза число 3 , коунтер выдаст = 1.
