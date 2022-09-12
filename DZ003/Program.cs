//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
int [,] mas = FillArray(4, 4);

PrintArray(mas);

int [,] ArithmeticMean(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            sum += massiv[j,i];
        }
        double arifmetic = sum/massiv.GetLength(1);
        Console.WriteLine($"Среднее арифметическое {i+1} столбца равно: {Math.Round(arifmetic,1)} ");
    }
    return massiv;    
}
ArithmeticMean(mas);

