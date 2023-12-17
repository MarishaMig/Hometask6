/*Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. 
a b c => “abcdef” 
d e f */

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