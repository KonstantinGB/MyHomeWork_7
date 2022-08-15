/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine();
    }
}

void ShowArithmeticAverage(int [,] array)
{
    Console.Write("Среднее арифмитическое столбцов:");
    double ArithmeticAverage = 0;
    for(int j = 0; j < array.GetLength(0); j++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            ArithmeticAverage = array[i,j] + ArithmeticAverage;
        } 
        Console.Write($" {ArithmeticAverage / array.GetLength(1)}   ");
        ArithmeticAverage = 0;
    }
}


int [,] array = CreateRandom2dArray(4, 4, 1, 10);
Show2dArray(array);
ShowArithmeticAverage(array);
