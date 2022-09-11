//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int [,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] FillArray(int line, int column)
{
    int [,] array = new int [line,column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        array [i,j] = new Random().Next(1,10);
    }
    return array;
}
int [,] mas = FillArray(3, 3);

PrintArray(mas);

void FindElement(int [,] massiv)
{
    if (m < 0 || m > massiv.GetLength(0)-1 || n < 0 || n > massiv.GetLength(1)-1) Console.WriteLine("Такого числа нет");
    else Console.WriteLine($"Число найдено: {massiv[m,n]}");
}   
FindElement(mas);
