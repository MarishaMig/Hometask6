﻿/*Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. 
a b c => “abcdef” 
d e f */
/*
char[,] array = new char[4,3];
string s=string.Empty;

void CreateArray()
{
         for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToChar(new Random().Next('a', 'a' + 27));
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}
string GetString (char[,] array)
{
    string s=string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            s+=array[i,j];
        }
    }
    return s;
}
CreateArray();
PrintArray();
Console.WriteLine("------");
s=GetString (array);
Console.WriteLine(s);
*/

/*Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой 
все заглавные буквы заменены на строчные. 
“aBcD1ef!-” => “abcd1ef!-” */

/*
Console.Write("Введите строку, содержащую латинские буквы в обоих регистрах: ");
string s=Console.ReadLine();
string news=string.Empty;

for(int i=0;i<s.Length;i++)
{   
    news += s.ToLower()[i];
}
 
Console.WriteLine("-------");
Console.WriteLine(s+" => "+news);
*/

/*Задайте произвольную строку. Выясните, является ли она палиндромом. 
“aBcD1ef!-” => Нет 
“шалаш” => Да 
“55655” => Да */

//Console.Write("Введите строку: ");  //проблема с вводом
    //string? str=Console.ReadLine();

    /*
    string str="шалаш";
    bool res=true;
    for(int i=0;i<=str.Length/2;i++)
    {   
        if (str[i]!=str[str.Length-1-i])
        {
            res=false;
            Console.WriteLine($"{str} => Нет");
            break;
        }
    }
    if (res==true)
    {
        Console.WriteLine($"{str} => Да"); 
    }
    */

    